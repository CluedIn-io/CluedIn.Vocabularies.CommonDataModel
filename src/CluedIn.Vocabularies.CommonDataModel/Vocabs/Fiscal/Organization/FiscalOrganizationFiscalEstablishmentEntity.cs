using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalOrganizationFiscalEstablishmentEntityVocabulary : SimpleVocabulary
    {
        public FiscalOrganizationFiscalEstablishmentEntityVocabulary()
        {
            VocabularyName = "FiscalOrganizationFiscalEstablishmentEntity";
            KeyPrefix = "commonDataModel.fiscalorganizationfiscalestablishmententity";
            KeySeparator = ".";
            Grouping = "/FiscalOrganizationFiscalEstablishmentEntity";

            AddGroup("FiscalOrganizationFiscalEstablishmentEntity Details", group =>
            {
                FiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(FiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishment = group.Add(new VocabularyKey(nameof(FiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOrganization_BR = group.Add(new VocabularyKey(nameof(FiscalOrganization_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(RootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishment = group.Add(new VocabularyKey(nameof(RootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey FiscalEstablishment { get; private set; }
        public VocabularyKey FiscalOrganization_BR { get; private set; }
        public VocabularyKey RootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey RootFiscalEstablishment { get; private set; }


    }
}