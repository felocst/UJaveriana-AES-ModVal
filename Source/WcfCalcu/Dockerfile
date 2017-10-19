# install WCF basic docker image

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
