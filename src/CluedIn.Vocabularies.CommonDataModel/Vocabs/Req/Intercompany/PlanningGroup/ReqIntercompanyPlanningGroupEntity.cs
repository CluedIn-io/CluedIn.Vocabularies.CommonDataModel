using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqIntercompanyPlanningGroupEntityVocabulary : SimpleVocabulary
    {
        public ReqIntercompanyPlanningGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqIntercompanyPlanningGroupEntity";
            KeyPrefix = "commonDataModel.reqintercompanyplanninggroupentity";
            KeySeparator = ".";
            Grouping = "/ReqIntercompanyPlanningGroupEntity";

            AddGroup("Common Data Model ReqIntercompanyPlanningGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}