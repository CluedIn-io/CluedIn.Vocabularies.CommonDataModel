using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DealerPlateVocabulary : SimpleVocabulary
    {
        public DealerPlateVocabulary()
        {
            VocabularyName = "Dealer Plate";
            KeyPrefix = "commonDataModel.dealerplate.automotive";
            KeySeparator = ".";
            Grouping = "/DealerPlate";

            AddGroup("DealerPlate Details for Automotive", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DealerPlateId = group.Add(new VocabularyKey(nameof(DealerPlateId), "Dealer Plate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IssuedBy = group.Add(new VocabularyKey(nameof(IssuedBy), "Issued By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), "Registration Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey DealerPlateId { get; private set; }
        public VocabularyKey IssuedBy { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}