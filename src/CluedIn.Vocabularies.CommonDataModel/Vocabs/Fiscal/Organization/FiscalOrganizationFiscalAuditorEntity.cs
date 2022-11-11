using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalOrganizationFiscalAuditorEntityVocabulary : SimpleVocabulary
    {
        public FiscalOrganizationFiscalAuditorEntityVocabulary()
        {
            VocabularyName = "FiscalOrganizationFiscalAuditorEntity";
            KeyPrefix = "commonDataModel.fiscalorganizationfiscalauditorentity";
            KeySeparator = ".";
            Grouping = "/FiscalOrganizationFiscalAuditorEntity";

            AddGroup("FiscalOrganizationFiscalAuditorEntity Details", group =>
            {
                CVMNumber = group.Add(new VocabularyKey(nameof(CVMNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(RootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishment = group.Add(new VocabularyKey(nameof(RootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CVMNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey RootFiscalEstablishment { get; private set; }


    }
}