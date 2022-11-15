using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailHardwareProfileFiscalIntegrationTechnicalProfileLineEntityVocabulary : SimpleVocabulary
    {
        public RetailHardwareProfileFiscalIntegrationTechnicalProfileLineEntityVocabulary()
        {
            VocabularyName = "Retail Hardware Profile Fiscal Integration Technical Profile Line Entity";
            KeyPrefix = "commonDataModel.retailhardwareprofilefiscalintegrationtechnicalprofilelineentity";
            KeySeparator = ".";
            Grouping = "/RetailHardwareProfileFiscalIntegrationTechnicalProfileLineEntity";

            AddGroup("RetailHardwareProfileFiscalIntegrationTechnicalProfileLineEntity Details", group =>
            {
                HardwareProfileId = group.Add(new VocabularyKey(nameof(HardwareProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalTechnicalProfileId = group.Add(new VocabularyKey(nameof(FiscalTechnicalProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey HardwareProfileId { get; private set; }
        public VocabularyKey FiscalTechnicalProfileId { get; private set; }
    }
}