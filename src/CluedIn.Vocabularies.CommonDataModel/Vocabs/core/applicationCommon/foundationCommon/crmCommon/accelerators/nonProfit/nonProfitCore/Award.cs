using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class AwardVocabulary : SimpleVocabulary
    {
        public AwardVocabulary()
        {
            VocabularyName = "Award";
            KeyPrefix = "commonDataModel.award.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Award";

            AddGroup("Award Details for NonProfitCore", group =>
            {
			    AwardId = group.Add(new VocabularyKey(nameof(AwardId), "Award", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoticeOfAwardChannel = group.Add(new VocabularyKey(nameof(NoticeOfAwardChannel), "Notice Of Award Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoticeOfAwardDate = group.Add(new VocabularyKey(nameof(NoticeOfAwardDate), "Notice of Award Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AwardId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NoticeOfAwardChannel { get; private set; }
        public VocabularyKey NoticeOfAwardDate { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}