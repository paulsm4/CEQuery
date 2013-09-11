CEQuery: Sample code for PO8 4.5++/5.x Content Engine SQL queries

USAGE:
------
1) Copy platform-specific version of FileNet.Api.dll
2) P8 4.5x-only: 
   a) Install Microsoft WSE 3.0
   b) #define P8_451 
   c) Target project for .Net 3.0 (removing extraneous .Net 4.0++ references)
3) Compile and build
4) Verify client can connect to P8
5) Select and execute example query

Config Settings:
----------------
P8 4.5:
  Project, Build, Conditional compilation symbols: P8_451
  ceUri:    http://RGBFileNet451:9080/wsi/FNCEWS40MTOM/
  osName:   OS3                                           
  INFOLDER: /eForms                                           
P8 5.x:                                   -------
  Project, Build, Conditional compilation symbols: P8_511
  ceUri:    http://ecmdemo1:9080/wsi/FNCEWS40TOM/
  osName:   ECM
  INFOLDER: /GIT/System                                        
