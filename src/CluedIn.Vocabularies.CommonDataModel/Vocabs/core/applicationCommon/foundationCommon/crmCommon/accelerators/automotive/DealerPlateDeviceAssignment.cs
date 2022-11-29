using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DealerPlateDeviceAssignmentVocabulary : SimpleVocabulary
    {
        public DealerPlateDeviceAssignmentVocabulary()
        {
            VocabularyName = "Dealer Plate Device Assignment";
            KeyPrefix = "commonDataModel.dealerplatedeviceassignment.automotive";
            KeySeparator = ".";
            Grouping = "/DealerPlateDeviceAssignment";

            AddGroup("DealerPlateDeviceAssignment Details for Automotive", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DealerPlateDeviceAssignmentId = group.Add(new VocabularyKey(nameof(DealerPlateDeviceAssignmentId), "Dealer Plate Device Assignment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey DealerPlateDeviceAssignmentId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}