using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class WaitlistItemVocabulary : SimpleVocabulary
    {
        public WaitlistItemVocabulary()
        {
            VocabularyName = "Waitlist Item";
            KeyPrefix = "commonDataModel.waitlistitem.eventmanagement";
            KeySeparator = ".";
            Grouping = "/WaitlistItem";

            AddGroup("WaitlistItem Details for EventManagement", group =>
            {
			    WaitListItemId = group.Add(new VocabularyKey(nameof(WaitListItemId), "Waitlist Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AutomaticallyRegister = group.Add(new VocabularyKey(nameof(AutomaticallyRegister), "Automatically Register", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Invited = group.Add(new VocabularyKey(nameof(Invited), "Invited", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Reserved = group.Add(new VocabularyKey(nameof(Reserved), "Reserved", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WaitListItemId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AutomaticallyRegister { get; private set; }
        public VocabularyKey Invited { get; private set; }
        public VocabularyKey Reserved { get; private set; }
    }
}