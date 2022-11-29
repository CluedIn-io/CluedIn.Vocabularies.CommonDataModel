using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AdditionalNameVocabulary : SimpleVocabulary
    {
        public AdditionalNameVocabulary()
        {
            VocabularyName = "Additional Name";
            KeyPrefix = "commonDataModel.additionalname.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AdditionalName";

            AddGroup("AdditionalName Details for ElectronicMedicalRecords", group =>
            {
			    AdditionalNameId = group.Add(new VocabularyKey(nameof(AdditionalNameId), "Additional Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyName = group.Add(new VocabularyKey(nameof(FamilyName), "Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NameUse = group.Add(new VocabularyKey(nameof(NameUse), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prefix = group.Add(new VocabularyKey(nameof(Prefix), "Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Suffix = group.Add(new VocabularyKey(nameof(Suffix), "Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdditionalNameId { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FamilyName { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NameUse { get; private set; }
        public VocabularyKey Prefix { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}