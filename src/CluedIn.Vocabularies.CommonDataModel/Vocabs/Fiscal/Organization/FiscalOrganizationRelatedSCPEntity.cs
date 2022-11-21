using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalOrganizationRelatedSCPEntityVocabulary : SimpleVocabulary
    {
        public FiscalOrganizationRelatedSCPEntityVocabulary()
        {
            VocabularyName = "Fiscal Organization Related SCP Entity";
            KeyPrefix = "commonDataModel.fiscalorganizationrelatedscpentity";
            KeySeparator = ".";
            Grouping = "/FiscalOrganizationRelatedSCPEntity";

            AddGroup("FiscalOrganizationRelatedSCPEntity Details", group =>
            {
                RootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(RootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishment = group.Add(new VocabularyKey(nameof(RootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey RootFiscalEstablishment { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}