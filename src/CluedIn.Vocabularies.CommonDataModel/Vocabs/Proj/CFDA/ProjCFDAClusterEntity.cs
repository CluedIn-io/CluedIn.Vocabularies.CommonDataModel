using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCFDAClusterEntityVocabulary : SimpleVocabulary
    {
        public ProjCFDAClusterEntityVocabulary()
        {
            VocabularyName = "ProjCFDAClusterEntity";
            KeyPrefix = "commonDataModel.projcfdaclusterentity";
            KeySeparator = ".";
            Grouping = "/ProjCFDAClusterEntity";

            AddGroup("ProjCFDAClusterEntity Details", group =>
            {
                ClusterName = group.Add(new VocabularyKey(nameof(ClusterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClusterName { get; private set; }


    }
}