using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PCProductConfigurationModelVersionEntityVocabulary : SimpleVocabulary
    {
        public PCProductConfigurationModelVersionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PCProductConfigurationModelVersionEntity";
            KeyPrefix = "commonDataModel.pcproductconfigurationmodelversionentity";
            KeySeparator = ".";
            Grouping = "/PCProductConfigurationModelVersionEntity";

            AddGroup("Common Data Model PCProductConfigurationModelVersionEntity Details", group =>
            {
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationModelName = group.Add(new VocabularyKey(nameof(ProductConfigurationModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceMethod = group.Add(new VocabularyKey(nameof(PriceMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey ProductConfigurationModelName { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey PriceMethod { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }


    }
}