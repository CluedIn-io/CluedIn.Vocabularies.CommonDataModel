using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerPostingProfileHeaderEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerPostingProfileHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCustomerPostingProfileHeaderEntity";
            KeyPrefix = "commonDataModel.custcustomerpostingprofileheaderentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerPostingProfileHeaderEntity";

            AddGroup("Common Data Model CustCustomerPostingProfileHeaderEntity Details", group =>
            {
                IsTransactionIncludedInCollectionLetterGeneration = group.Add(new VocabularyKey(nameof(IsTransactionIncludedInCollectionLetterGeneration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransactionIncludedInInterestCalculation = group.Add(new VocabularyKey(nameof(IsTransactionIncludedInInterestCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileToCloseSettlement = group.Add(new VocabularyKey(nameof(PostingProfileToCloseSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransactionIncludedInAutoSettlement = group.Add(new VocabularyKey(nameof(IsTransactionIncludedInAutoSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowEmptyDimensionValue = group.Add(new VocabularyKey(nameof(AllowEmptyDimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsTransactionIncludedInCollectionLetterGeneration { get; private set; }
        public VocabularyKey IsTransactionIncludedInInterestCalculation { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey PostingProfileToCloseSettlement { get; private set; }
        public VocabularyKey IsTransactionIncludedInAutoSettlement { get; private set; }
        public VocabularyKey AllowEmptyDimensionValue { get; private set; }


    }
}