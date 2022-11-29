using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class SalutationVocabulary : SimpleVocabulary
    {
        public SalutationVocabulary()
        {
            VocabularyName = "Salutation";
            KeyPrefix = "commonDataModel.salutation.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Salutation";

            AddGroup("Salutation Details for NonProfitCore", group =>
            {
			    AddressLabelLine1 = group.Add(new VocabularyKey(nameof(AddressLabelLine1), "Address Label Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLabelLine2 = group.Add(new VocabularyKey(nameof(AddressLabelLine2), "Address Label Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLabelLine3 = group.Add(new VocabularyKey(nameof(AddressLabelLine3), "Address Label Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommunicationMethod = group.Add(new VocabularyKey(nameof(CommunicationMethod), "Communication Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConstituentType = group.Add(new VocabularyKey(nameof(ConstituentType), "Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullName = group.Add(new VocabularyKey(nameof(FullName), "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsideSalutation = group.Add(new VocabularyKey(nameof(InsideSalutation), "Inside Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPreferred = group.Add(new VocabularyKey(nameof(IsPreferred), "Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnBehalfOfAccount = group.Add(new VocabularyKey(nameof(OnBehalfOfAccount), "On Behalf Of Account", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalutationId = group.Add(new VocabularyKey(nameof(SalutationId), "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Suffix = group.Add(new VocabularyKey(nameof(Suffix), "Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressLabelLine1 { get; private set; }
        public VocabularyKey AddressLabelLine2 { get; private set; }
        public VocabularyKey AddressLabelLine3 { get; private set; }
        public VocabularyKey CommunicationMethod { get; private set; }
        public VocabularyKey ConstituentType { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey InsideSalutation { get; private set; }
        public VocabularyKey IsPreferred { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OnBehalfOfAccount { get; private set; }
        public VocabularyKey SalutationId { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}