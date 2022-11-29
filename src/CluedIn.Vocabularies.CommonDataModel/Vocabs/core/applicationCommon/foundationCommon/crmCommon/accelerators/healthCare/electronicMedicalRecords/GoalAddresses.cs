using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class GoalAddressesVocabulary : SimpleVocabulary
    {
        public GoalAddressesVocabulary()
        {
            VocabularyName = "Goal Addresses";
            KeyPrefix = "commonDataModel.goaladdresses.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/GoalAddresses";

            AddGroup("GoalAddresses Details for ElectronicMedicalRecords", group =>
            {
			    AddressesType = group.Add(new VocabularyKey(nameof(AddressesType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalAddressesId = group.Add(new VocabularyKey(nameof(GoalAddressesId), "Goal Addresses", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressesType { get; private set; }
        public VocabularyKey GoalAddressesId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}