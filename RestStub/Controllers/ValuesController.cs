﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestStub.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "N/A"
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return " ";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
    /*
     {
   \"EsetNumber\": \"1\",
   \"OrderNumber\": null,
   \"OrganizationCode\": \"HEL\",
   \"JobNumber\": \"J16997582\",
   \"SerialNumber\": \"SJ419030011WA\",
   \"MACAddress\": null,
   \"SoftwareExtension\": null,
   \"OperatorName\": \"eDelivery\",
   \"ClientName\": \"eDelivery\",
   \"ClientType\": \"eDelivery\",
   \"OrderType\": null,
   \"TransactionType\": \"Upgrade\",
   \"ForkliftSerialNumber\": null,
   \"ReportTypes\": \"xml\",
   \"Reports\": {\"Report\": [   {
      \"FileExtensionName\": \"xml\",
      \"FileName\": \"SJ419030011WA_OAC.xml\",
      \"FileContent\": \"********\",
   }]},
   \"ErrorDetails\":    {
      \"ErrorCode\": null,
      \"ErrorMessage\": null
   },
   \"ResponseDetails\":    {
      \"ResponseCode\": 200,
      \"ResponseMessage\": \"Success\"
   }
    }







    {
   "EsetNumber": "1",
   "OrderNumber": null,
   "OrganizationCode": "HEL",
   "JobNumber": "J16997582",
   "SerialNumber": "SJ419030011WA",
   "MACAddress": null,
   "SoftwareExtension": null,
   "OperatorName": "eDelivery",
   "ClientName": "eDelivery",
   "ClientType": "eDelivery",
   "OrderType": null,
   "TransactionType": "Upgrade",
   "ForkliftSerialNumber": null,
   "ReportTypes": "xml",
   "Reports": {"Report": [   {
      "FileExtensionName": "xml",
      "FileName": "SJ419030011WA_OAC.xml",
      "FileContent": "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iSVNPLTg4NTktMSI/PjxPcHRhY3RSZXNwb25zZT48SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAwMjwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+UjEyTDwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIFJFU1QgMTIgTEVBRCBESVNQTEFZPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TV09QVDwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPjMwNjY3NjE3MjI3NjwvQUNUSVZBVElPTl9DT0RFPjxMSUNFTlNFX1FUWT4xPC9MSUNFTlNFX1FUWT48RVhQSVJBVElPTl9EQVRFPm51bGw8L0VYUElSQVRJT05fREFURT48L0lURU1fREVUQUlMUz4NCjxJVEVNX0RFVEFJTFM+PElURU1fTlVNQkVSPjIwMzc5ODYtMDA0PC9JVEVNX05VTUJFUj48TElDRU5TRV9UWVBFPk5vcm1hbDwvTElDRU5TRV9UWVBFPjxPUFRJT05fQ09ERT5NSTEyPC9PUFRJT05fQ09ERT48T1BUSU9OX05BTUU+T1BUIEFDVCBNQUM4MDAgTUVBUy9JTlRFUlAgMTJTTDwvT1BUSU9OX05BTUU+PFhNTF9UQUc+U1dPUFQ8L1hNTF9UQUc+PEFDVElWQVRJT05fQ09ERT40MDA3NjU1Njc3NzM8L0FDVElWQVRJT05fQ09ERT48TElDRU5TRV9RVFk+MTwvTElDRU5TRV9RVFk+PEVYUElSQVRJT05fREFURT5udWxsPC9FWFBJUkFUSU9OX0RBVEU+PC9JVEVNX0RFVEFJTFM+DQo8SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAwNTwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+TTEwMDwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIFNUT1JBR0UgRk9SIDEwMCBFQ0dTPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TV09QVDwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPjE2MjM1Mjc1MzA3MzwvQUNUSVZBVElPTl9DT0RFPjxMSUNFTlNFX1FUWT4xPC9MSUNFTlNFX1FUWT48RVhQSVJBVElPTl9EQVRFPm51bGw8L0VYUElSQVRJT05fREFURT48L0lURU1fREVUQUlMUz4NCjxJVEVNX0RFVEFJTFM+PElURU1fTlVNQkVSPjIwMzc5ODYtMDA2PC9JVEVNX05VTUJFUj48TElDRU5TRV9UWVBFPk5vcm1hbDwvTElDRU5TRV9UWVBFPjxPUFRJT05fQ09ERT5MQU5DPC9PUFRJT05fQ09ERT48T1BUSU9OX05BTUU+T1BUIEFDVCBNQUM4MDAgTEFOL1NFUklBTCBQT1JUIFRPIENBUkQ8L09QVElPTl9OQU1FPjxYTUxfVEFHPlNXT1BUPC9YTUxfVEFHPjxBQ1RJVkFUSU9OX0NPREU+NzQxMjAyMDUwMzE3PC9BQ1RJVkFUSU9OX0NPREU+PExJQ0VOU0VfUVRZPjE8L0xJQ0VOU0VfUVRZPjxFWFBJUkFUSU9OX0RBVEU+bnVsbDwvRVhQSVJBVElPTl9EQVRFPjwvSVRFTV9ERVRBSUxTPg0KPElURU1fREVUQUlMUz48SVRFTV9OVU1CRVI+MjAzNzk4Ni0wMDc8L0lURU1fTlVNQkVSPjxMSUNFTlNFX1RZUEU+Tm9ybWFsPC9MSUNFTlNFX1RZUEU+PE9QVElPTl9DT0RFPkxBTk08L09QVElPTl9DT0RFPjxPUFRJT05fTkFNRT5PUFQgQUNUIE1BQzgwMCBMQU4vU0VSSUFMIFBPUlQgVE8gTVVTRTwvT1BUSU9OX05BTUU+PFhNTF9UQUc+U1dPUFQ8L1hNTF9UQUc+PEFDVElWQVRJT05fQ09ERT4yMTI3Mjc3NTczNzI8L0FDVElWQVRJT05fQ09ERT48TElDRU5TRV9RVFk+MTwvTElDRU5TRV9RVFk+PEVYUElSQVRJT05fREFURT5udWxsPC9FWFBJUkFUSU9OX0RBVEU+PC9JVEVNX0RFVEFJTFM+DQo8SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAxMTwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+QkNSRDwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIFVTQiBCQVJDT0RFIFJFQURFUjwvT1BUSU9OX05BTUU+PFhNTF9UQUc+U1dPUFQ8L1hNTF9UQUc+PEFDVElWQVRJT05fQ09ERT41NzE1MjcyNjU2NDc8L0FDVElWQVRJT05fQ09ERT48TElDRU5TRV9RVFk+MTwvTElDRU5TRV9RVFk+PEVYUElSQVRJT05fREFURT5udWxsPC9FWFBJUkFUSU9OX0RBVEU+PC9JVEVNX0RFVEFJTFM+DQo8SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAxMzwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+UlJBTjwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIFJSIFRFU1QgQU5EIEFOQUxZU0lTPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TV09QVDwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPjU0NTQ1NzM1NTY1MDwvQUNUSVZBVElPTl9DT0RFPjxMSUNFTlNFX1FUWT4xPC9MSUNFTlNFX1FUWT48RVhQSVJBVElPTl9EQVRFPm51bGw8L0VYUElSQVRJT05fREFURT48L0lURU1fREVUQUlMUz4NCjxJVEVNX0RFVEFJTFM+PElURU1fTlVNQkVSPjIwMzc5ODYtMDE0PC9JVEVNX05VTUJFUj48TElDRU5TRV9UWVBFPk5vcm1hbDwvTElDRU5TRV9UWVBFPjxPUFRJT05fQ09ERT5QREZDPC9PUFRJT05fQ09ERT48T1BUSU9OX05BTUU+T1BUIEFDVCBNQUM4MDAgUERGIFJFTjwvT1BUSU9OX05BTUU+PFhNTF9UQUc+U1dPUFQ8L1hNTF9UQUc+PEFDVElWQVRJT05fQ09ERT42MDcyNDcxMjc2MTY8L0FDVElWQVRJT05fQ09ERT48TElDRU5TRV9RVFk+MTwvTElDRU5TRV9RVFk+PEVYUElSQVRJT05fREFURT5udWxsPC9FWFBJUkFUSU9OX0RBVEU+PC9JVEVNX0RFVEFJTFM+DQo8SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAyMzwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+TFBSVDwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIExBU0VSIFBSSU5URVIgU1VQUE9SVDwvT1BUSU9OX05BTUU+PFhNTF9UQUc+U1dPUFQ8L1hNTF9UQUc+PEFDVElWQVRJT05fQ09ERT42MjQxNTM3NDAzNjM8L0FDVElWQVRJT05fQ09ERT48TElDRU5TRV9RVFk+MTwvTElDRU5TRV9RVFk+PEVYUElSQVRJT05fREFURT5udWxsPC9FWFBJUkFUSU9OX0RBVEU+PC9JVEVNX0RFVEFJTFM+DQo8SVRFTV9ERVRBSUxTPjxJVEVNX05VTUJFUj4yMDM3OTg2LTAyNDwvSVRFTV9OVU1CRVI+PExJQ0VOU0VfVFlQRT5Ob3JtYWw8L0xJQ0VOU0VfVFlQRT48T1BUSU9OX0NPREU+V0lGQzwvT1BUSU9OX0NPREU+PE9QVElPTl9OQU1FPk9QVCBBQ1QgTUFDODAwIFdJRkMgLSBXSUZJIFRPIENBUkQ8L09QVElPTl9OQU1FPjxYTUxfVEFHPlNXT1BUPC9YTUxfVEFHPjxBQ1RJVkFUSU9OX0NPREU+NjcyNTMyMjU3NTc0PC9BQ1RJVkFUSU9OX0NPREU+PExJQ0VOU0VfUVRZPjE8L0xJQ0VOU0VfUVRZPjxFWFBJUkFUSU9OX0RBVEU+bnVsbDwvRVhQSVJBVElPTl9EQVRFPjwvSVRFTV9ERVRBSUxTPg0KPElURU1fREVUQUlMUz48SVRFTV9OVU1CRVI+MjAzNzk4Ni0wMjU8L0lURU1fTlVNQkVSPjxMSUNFTlNFX1RZUEU+Tm9ybWFsPC9MSUNFTlNFX1RZUEU+PE9QVElPTl9DT0RFPldJRk08L09QVElPTl9DT0RFPjxPUFRJT05fTkFNRT5PUFQgQUNUIE1BQzgwMCBXSUZNIC0gV0lGSSBUTyBNVVNFPC9PUFRJT05fTkFNRT48WE1MX1RBRz5TV09QVDwvWE1MX1RBRz48QUNUSVZBVElPTl9DT0RFPjc1NTIwNzcyNTc0MzwvQUNUSVZBVElPTl9DT0RFPjxMSUNFTlNFX1FUWT4xPC9MSUNFTlNFX1FUWT48RVhQSVJBVElPTl9EQVRFPm51bGw8L0VYUElSQVRJT05fREFURT48L0lURU1fREVUQUlMUz4NCjxTRVJJQUxfTlVNQkVSPlNKNDE5MDMwMDExV0E8L1NFUklBTF9OVU1CRVI+PERBVEVfQ09ORklHVVJFRD4wMS8yNS8yMDE5IDA4OjI5OjExIEFNPC9EQVRFX0NPTkZJR1VSRUQ+PENVU1RPTUVSX0FERFJFU1M+S3VlaG5lICsgTmFnZWwgKEFHICZhbXA7IENvLikgS0csYy9vIEdFIEhlYWx0aGNhcmUsRnJhbmtmdXJ0ZXJzdHIuIDEyOCxSYXVuaGVpbSwsLDY1NDc5LERFPC9DVVNUT01FUl9BRERSRVNTPjxNT0RFTF9OQU1FPk1BQyA4MDA8L01PREVMX05BTUU+PE9SR0FOSVpBVElPTl9DT0RFPkhFTDwvT1JHQU5JWkFUSU9OX0NPREU+PENVU1RPTUVSX05VTUJFUj42OTEyMjwvQ1VTVE9NRVJfTlVNQkVSPjxDVVNUT01FUl9OQU1FPkdFIE1FRElDQUwgU1lTVEVNUyBJTkZPUk1BVElPTiBURUNITk9MT0dJRVMgR01CSDwvQ1VTVE9NRVJfTkFNRT48RVJQX0lOU1RBTkNFPkc8L0VSUF9JTlNUQU5DRT48Sk9CX05VTUJFUj5KMTY5OTc1ODE8L0pPQl9OVU1CRVI+PE9SREVSX05VTUJFUj4yMjU2MzQxPC9PUkRFUl9OVU1CRVI+PFBBUkVOVF9JVEVNX05VTUJFUj4yMDYxMzU0LTAwMS01MTQ0MDg8L1BBUkVOVF9JVEVNX05VTUJFUj48L09wdGFjdFJlc3BvbnNlPg=="
   }]},
   "ErrorDetails":    {
      "ErrorCode": null,
      "ErrorMessage": null
   },
   "ResponseDetails":    {
      "ResponseCode": 200,
      "ResponseMessage": "Success"
   }
}

     
     */
}
