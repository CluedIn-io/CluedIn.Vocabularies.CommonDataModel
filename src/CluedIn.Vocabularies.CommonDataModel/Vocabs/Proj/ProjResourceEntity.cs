using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjResourceEntityVocabulary : SimpleVocabulary
    {
        public ProjResourceEntityVocabulary()
        {
            VocabularyName = "ProjResourceEntity";
            KeyPrefix = "commonDataModel.projresourceentity";
            KeySeparator = ".";
            Grouping = "/ProjResourceEntity";

            AddGroup("ProjResourceEntity Details", group =>
            {
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}