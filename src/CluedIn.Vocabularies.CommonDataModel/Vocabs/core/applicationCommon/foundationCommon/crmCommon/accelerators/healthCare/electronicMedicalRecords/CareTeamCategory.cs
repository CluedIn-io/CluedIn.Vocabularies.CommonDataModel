using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamCategoryVocabulary : SimpleVocabulary
    {
        public CareTeamCategoryVocabulary()
        {
            VocabularyName = "Care Team Category";
            KeyPrefix = "commonDataModel.careteamcategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeamCategory";

            AddGroup("CareTeamCategory Details for ElectronicMedicalRecords", group =>
            {
			    CareTeamCategoryId = group.Add(new VocabularyKey(nameof(CareTeamCategoryId), "Care Team Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CareTeamCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}