using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PaymentMethodVocabulary : SimpleVocabulary
    {
        public PaymentMethodVocabulary()
        {
            VocabularyName = "Payment Method";
            KeyPrefix = "commonDataModel.paymentmethod.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/PaymentMethod";

            AddGroup("PaymentMethod Details for NonProfitCore", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatus = group.Add(new VocabularyKey(nameof(LastAuthenticationStatus), "Last Authentication Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusDate = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusDate), "Last Authentication Status Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusDetail = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusDetail), "Last Authentication Status Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusTechnicalDetail = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusTechnicalDetail), "Last Authentication Status Technical Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentMethodId = group.Add(new VocabularyKey(nameof(PaymentMethodId), "Payment Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey LastAuthenticationStatus { get; private set; }
        public VocabularyKey LastAuthenticationStatusDate { get; private set; }
        public VocabularyKey LastAuthenticationStatusDetail { get; private set; }
        public VocabularyKey LastAuthenticationStatusTechnicalDetail { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentMethodId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}