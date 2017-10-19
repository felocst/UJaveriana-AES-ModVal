# UJaveriana-AES-ModVal
Ws Suma Numeros

Servicio WCF .NET Framework 4.0 Visual Studio 2017.

Docker for windows 10 Pro

Servicio WcfCalcu

 Function SumaNumeros(ByVal reqSumandos As Sumandos) As Int32
 
 Public Class Sumandos
    Private _sumando1 As Int32
    Private _sumando2 As Int32

    Public Property Sumando1 As Int32
        Get
            Return _sumando1
        End Get
        Set(value As Int32)
            _sumando1 = value
        End Set
    End Property

    Public Property Sumando2 As Int32
        Get
            Return _sumando2
        End Get
        Set(value As Int32)
            _sumando2 = value
        End Set
    End Property
End Class


FROM microsoft/wcf:4.6.2

# Next, this Dockerfile creates a directory for your application
WORKDIR WcfCalcu

# configure the new site in IIS.
RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    New-IISSite -Name "WcfCalcu" -PhysicalPath C:\WcfCalcu -BindingInformation "*:83:"

# This instruction tells the container to listen on port 83. 
EXPOSE 83

# The final instruction copies the site you published earlier into the container.
COPY WcfCalcu/ .

EJEMPLO Request Servicio SOAP

<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/" xmlns:wcf="http://schemas.datacontract.org/2004/07/WcfCalcu">
   <soapenv:Header/>
   <soapenv:Body>
      <tem:SumaNumeros>
         <!--Optional:-->
         <tem:reqSumandos>
            <!--Optional:-->
            <wcf:Sumando1>6</wcf:Sumando1>
            <!--Optional:-->
            <wcf:Sumando2>7</wcf:Sumando2>
         </tem:reqSumandos>
      </tem:SumaNumeros>
   </soapenv:Body>
</soapenv:Envelope>

Ejemplo Response

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
   <s:Body>
      <SumaNumerosResponse xmlns="http://tempuri.org/">
         <SumaNumerosResult>13</SumaNumerosResult>
      </SumaNumerosResponse>
   </s:Body>
</s:Envelope>
