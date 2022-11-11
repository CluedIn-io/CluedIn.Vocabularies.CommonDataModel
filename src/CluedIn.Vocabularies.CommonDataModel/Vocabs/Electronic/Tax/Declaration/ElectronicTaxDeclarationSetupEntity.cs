using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxDeclarationSetupEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxDeclarationSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicTaxDeclarationSetupEntity";
            KeyPrefix = "commonDataModel.electronictaxdeclarationsetupentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxDeclarationSetupEntity";

            AddGroup("Common Data Model ElectronicTaxDeclarationSetupEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Authentication = group.Add(new VocabularyKey(nameof(Authentication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProxyServerIPAddress = group.Add(new VocabularyKey(nameof(ProxyServerIPAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProxyServerPortNumber = group.Add(new VocabularyKey(nameof(ProxyServerPortNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseOfProxyServer = group.Add(new VocabularyKey(nameof(UseOfProxyServer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProxyServerAuthenticationRequired = group.Add(new VocabularyKey(nameof(ProxyServerAuthenticationRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ID { get; private set; }
        public VocabularyKey Authentication { get; private set; }
        public VocabularyKey ProxyServerIPAddress { get; private set; }
        public VocabularyKey ProxyServerPortNumber { get; private set; }
        public VocabularyKey UseOfProxyServer { get; private set; }
        public VocabularyKey ProxyServerAuthenticationRequired { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}