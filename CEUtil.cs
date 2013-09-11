#define P8_451

using System;
using System.Collections;
#if P8_451
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3.Security.Tokens;
#endif
using FileNet.Api.Action;
using FileNet.Api.Admin;
using FileNet.Api.Meta;
using FileNet.Api.Collection;
using FileNet.Api.Constants;
using FileNet.Api.Core;
using FileNet.Api.Property;
using FileNet.Api.Query;
using FileNet.Api.Util;

namespace WindowsFormsApplication1
{
    class CEUtil
    {
        private static CEUtil gCEUtil;
        private static IConnection conn;
        private static IDomain domain;
        private static IObjectStore objStore;
        private static bool isCredentialsEstablished;

        private const int MAX_RESULTS = 20;

        public delegate void LogMsg(string msg);
        private LogMsg logMsg;

        private CEUtil(string ceUri, string osName, string ceUser, string password, LogMsg logMsg)
        {
#if (P8_451)
            // P8 4.5 authentication
            UsernameToken token = new UsernameToken(ceUser, password, PasswordOption.SendPlainText);
            UserContext.SetProcessSecurityToken(token);
#else
            // P8 5.0 authentication
            UsernameCredentials cred = new UsernameCredentials(ceUser, password);
            ClientContext.SetProcessCredentials(cred);
#endif
            conn = Factory.Connection.GetConnection(ceUri);
            isCredentialsEstablished = true;

            // Get domain name
            PropertyFilter pf = new PropertyFilter();
            pf.AddIncludeProperty(0, null, null, "Name", null);
            pf.AddIncludeProperty(0, null, null, "Id", null);
            domain = Factory.Domain.FetchInstance(conn, null, null);
            objStore = Factory.ObjectStore.FetchInstance(domain, osName, null);

            // Successfully initialized CEUtil object: save singleton instance
            this.logMsg = logMsg;
            gCEUtil = this;
        }

        public void Close()
        {
            gCEUtil = null;
        }

        public IDomain Domain
        {
            get { return domain; }
        }

        public string DomainName
        {
            get { return domain.Name; }
        }

        public static CEUtil GetInstance (string ceUri, string osName, string ceUser, string password, LogMsg logMsg)
        {
            // Singleton
            if (gCEUtil == null)
                gCEUtil = new CEUtil (ceUri, osName, ceUser, password, logMsg);
            return gCEUtil;
        }

        public bool IsCredentialsEstablished
        {
            get { return isCredentialsEstablished; }
        }

        public IDocumentSet queryDocs(string sSql, int maxRecords, int pageSize)
        {
            logMsg("mkQuery(" + sSql + "), maxRecords=" + maxRecords + ", batchSize=" + pageSize + "...");
            SearchScope search = new SearchScope(objStore);
            SearchSQL searchSql = new SearchSQL();
            if (maxRecords > 0)
                searchSql.SetMaxRecords(maxRecords);
            // This must be done separately in order to call SetMaxRecords() etc
            searchSql.SetQueryString(sSql); 
            IDocumentSet documents =
                (IDocumentSet)search.FetchObjects(searchSql, pageSize, null, true);
            return documents;
        }

    }
}
