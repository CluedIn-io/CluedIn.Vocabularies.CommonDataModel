using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.automotive";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details for Automotive", group =>
            {
			    BusinessOperationId = group.Add(new VocabularyKey(nameof(BusinessOperationId), "Business Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Interest = group.Add(new VocabularyKey(nameof(Interest), "Interest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsResent = group.Add(new VocabularyKey(nameof(IsResent), "Is Resent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequestedOn = group.Add(new VocabularyKey(nameof(RequestedOn), "Requested On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RespondBefore = group.Add(new VocabularyKey(nameof(RespondBefore), "Respond Before", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceBusinessOperationId = group.Add(new VocabularyKey(nameof(SourceBusinessOperationId), "Source Business Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceName = group.Add(new VocabularyKey(nameof(SourceName), "Source Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceVersion = group.Add(new VocabularyKey(nameof(SourceVersion), "Source Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BusinessOperationId { get; private set; }
        public VocabularyKey Interest { get; private set; }
        public VocabularyKey IsResent { get; private set; }
        public VocabularyKey RequestedOn { get; private set; }
        public VocabularyKey RespondBefore { get; private set; }
        public VocabularyKey SourceBusinessOperationId { get; private set; }
        public VocabularyKey SourceName { get; private set; }
        public VocabularyKey SourceVersion { get; private set; }
    }
}