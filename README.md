Note on publishing: When using the publish feature in visual studio there is no need to manually create .svc files and web.config. Defaults will be generated from service namespace.


Generating proxy:
svcutil /config:app.config /out:"WCFSampleService.cs" /language:csharp /n:*, "http://gol-zb15.dips.local:8092/WCFSample.Service1.svc?wsdl"

Testing using Postman:
POST /WCFSample.Service1.svc HTTP/1.1
Host: localhost:8092
SOAPAction: "http://tempuri.org/IService1/GetData"
Content-Type: text/xml; charset=utf-8
Cache-Control: no-cache
Postman-Token: a3fe9187-7660-4027-abcb-ce43642c3e91

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/"><s:Body><GetData xmlns="http://tempuri.org/"><value>3</value></GetData></s:Body></s:Envelope>