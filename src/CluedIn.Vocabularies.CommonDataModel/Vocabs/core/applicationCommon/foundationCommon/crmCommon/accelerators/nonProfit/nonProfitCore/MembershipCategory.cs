using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class MembershipCategoryVocabulary : SimpleVocabulary
    {
        public MembershipCategoryVocabulary()
        {
            VocabularyName = "Membership Category";
            KeyPrefix = "commonDataModel.membershipcategory.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/MembershipCategory";

            AddGroup("MembershipCategory Details for NonProfitCore", group =>
            {
			    MembershipCategoryId = group.Add(new VocabularyKey(nameof(MembershipCategoryId), "Membership Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MembershipCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}