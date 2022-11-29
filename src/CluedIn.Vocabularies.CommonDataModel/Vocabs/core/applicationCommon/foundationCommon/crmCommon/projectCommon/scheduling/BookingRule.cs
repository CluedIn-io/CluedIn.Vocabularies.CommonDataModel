using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class BookingRuleVocabulary : SimpleVocabulary
    {
        public BookingRuleVocabulary()
        {
            VocabularyName = "Booking Rule";
            KeyPrefix = "commonDataModel.bookingrule.scheduling";
            KeySeparator = ".";
            Grouping = "/BookingRule";

            AddGroup("BookingRule Details for Scheduling", group =>
            {
			    BookingRuleId = group.Add(new VocabularyKey(nameof(BookingRuleId), "Booking Rule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeOfRule = group.Add(new VocabularyKey(nameof(CodeOfRule), "Code of Rule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MethodName = group.Add(new VocabularyKey(nameof(MethodName), "Method Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebResource = group.Add(new VocabularyKey(nameof(WebResource), "Web Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookingRuleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CodeOfRule { get; private set; }
        public VocabularyKey MethodName { get; private set; }
        public VocabularyKey WebResource { get; private set; }
    }
}