using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnCustomerReturnReasonCodeGroupEntityVocabulary : SimpleVocabulary
    {
        public ReturnCustomerReturnReasonCodeGroupEntityVocabulary()
        {
            VocabularyName = "Return Customer Return Reason Code Group Entity";
            KeyPrefix = "commonDataModel.returncustomerreturnreasoncodegroupentity";
            KeySeparator = ".";
            Grouping = "/ReturnCustomerReturnReasonCodeGroupEntity";

            AddGroup("ReturnCustomerReturnReasonCodeGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}