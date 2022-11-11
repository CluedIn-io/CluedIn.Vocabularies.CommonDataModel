using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommissionSalesRepresentativeGroupEntityVocabulary : SimpleVocabulary
    {
        public CommissionSalesRepresentativeGroupEntityVocabulary()
        {
            VocabularyName = "CommissionSalesRepresentativeGroupEntity";
            KeyPrefix = "commonDataModel.commissionsalesrepresentativegroupentity";
            KeySeparator = ".";
            Grouping = "/CommissionSalesRepresentativeGroupEntity";

            AddGroup("CommissionSalesRepresentativeGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}