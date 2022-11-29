using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address";
            KeyPrefix = "commonDataModel.address.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Address";

            AddGroup("Address Details for ElectronicMedicalRecords", group =>
            {
			    AddressTypeCode = group.Add(new VocabularyKey(nameof(AddressTypeCode), "Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressTypeCode { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}