# rbaz-Windows-communication-fundation-WCF

Création d’un service RESTful aven utilisant WCF

Windows Communication Foundation (WCF) est un Framework pour le développement et le déploiement de services sur Windows. 
WCF fournit un plate forme d'exécution pour les services, ils permettent d'exposer et de consommer les types CLR en tant que services et les services en tant que types CLR.

Prérequis
Microsoft Visual Studio 2017 ou supérieur
WCFTestClient.exe ou Postman pour tester notre API: https://www.getpostman.com/apps

Création du projet WCF
Démarrer Visual Studio.
Fichier > Nouveau > Projet
Visual C# et sélectionnez WCF, puis Application de service WCF
Configuration du fichier web.config


Configuration du fichier web.config
Ajouter le code ci-dessous dans la section <system.serviceModel>

      <system.serviceModel>
    <services>
      <service name="HDeskBellWCF.DepartmentService">
        <host>
          <baseAddresses>
            <add baseAddress = "http://localhost:50127/
                         Design_Time_Addresses/HDeskBellWCF/DepartmentService/" />
          </baseAddresses>
        </host>
        <endpoint address ="" binding="wsHttpBinding"

             contract = "HDeskBellWCF.IDepartmentService">
          <identity>
            <dns value="localhost"/>
          </identity>
        </endpoint>
        <endpoint address="mex" binding="mexHttpBinding"

               contract = "IMetadataExchange"/>
      </service>
    </services>
    <behaviors>
      <serviceBehaviors>
        <behavior>
          <!-- To avoid disclosing metadata information, set the values below to false before deployment -->
          <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true"/>
          <!-- To receive exception details in faults for debugging purposes, set the value below to true.  Set to false before
          deployment to avoid disclosing exception information -->
          <serviceDebug includeExceptionDetailInFaults="false"/>
        </behavior>
      </serviceBehaviors>
    </behaviors>
    <protocolMapping>
      <add binding="basicHttpsBinding" scheme="https" />
    </protocolMapping>
    <serviceHostingEnvironment aspNetCompatibilityEnabled="true" multipleSiteBindingsEnabled="true" />
  </system.serviceModel>


Test avec WCFTestClient ou postman


