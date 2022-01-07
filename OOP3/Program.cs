//interface

using OOP3;
using System.Collections.Generic;

//İnterfacelerde onu implemente eden clasın referans numarasını tutar

ICrediManager requirementCrediManager1 = new RequirementCrediManager();

ICrediManager transportCrediManager1 = new TransportCrediManager();

ICrediManager housingCrediManager1 = new HousingCrediManager();


ApplicationManager applicationManager = new ApplicationManager();

List<ILoggerService> logger = new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService() };

//applicationManager.MakeApplication(requirementCrediManager1,logger); Aşağıdaki ile aynı kod

applicationManager.MakeApplication(requirementCrediManager1, new List<ILoggerService> {new FileLoggerService(),
    new DataBaseLoggerService()}) ;
 

//ampulden system generic seçilcek list yapıldıktan sonra
List<ICrediManager> credits=  new List<ICrediManager>() {requirementCrediManager1 } ;

//applicationManager.DoPreİnformation(credits);

