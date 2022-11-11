using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectReportSortFieldsEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectReportSortFieldsEntityVocabulary()
        {
            VocabularyName = "ProjProjectReportSortFieldsEntity";
            KeyPrefix = "commonDataModel.projprojectreportsortfieldsentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectReportSortFieldsEntity";

            AddGroup("ProjProjectReportSortFieldsEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortCode = group.Add(new VocabularyKey(nameof(SortCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingId = group.Add(new VocabularyKey(nameof(SortingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey SortCode { get; private set; }
        public VocabularyKey SortingId { get; private set; }


    }
}