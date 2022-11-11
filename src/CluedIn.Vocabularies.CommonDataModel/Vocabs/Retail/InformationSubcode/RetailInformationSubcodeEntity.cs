using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInformationSubcodeEntityVocabulary : SimpleVocabulary
    {
        public RetailInformationSubcodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInformationSubcodeEntity";
            KeyPrefix = "commonDataModel.retailinformationsubcodeentity";
            KeySeparator = ".";
            Grouping = "/RetailInformationSubcodeEntity";

            AddGroup("Common Data Model RetailInformationSubcodeEntity Details", group =>
            {
                AmountPercent = group.Add(new VocabularyKey(nameof(AmountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceType = group.Add(new VocabularyKey(nameof(PriceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcodeId = group.Add(new VocabularyKey(nameof(SubcodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TriggerCode = group.Add(new VocabularyKey(nameof(TriggerCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TriggerFunction = group.Add(new VocabularyKey(nameof(TriggerFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountPercent { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InfocodeId { get; private set; }
        public VocabularyKey PriceType { get; private set; }
        public VocabularyKey SubcodeId { get; private set; }
        public VocabularyKey TriggerCode { get; private set; }
        public VocabularyKey TriggerFunction { get; private set; }


    }
}