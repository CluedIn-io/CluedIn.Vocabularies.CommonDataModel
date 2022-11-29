using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class WorkHourTemplateVocabulary : SimpleVocabulary
    {
        public WorkHourTemplateVocabulary()
        {
            VocabularyName = "Work Hour Template";
            KeyPrefix = "commonDataModel.workhourtemplate.scheduling";
            KeySeparator = ".";
            Grouping = "/WorkHourTemplate";

            AddGroup("WorkHourTemplate Details for Scheduling", group =>
            {
			    WorkHourTemplateId = group.Add(new VocabularyKey(nameof(WorkHourTemplateId), "Work Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WorkHourTemplateId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}