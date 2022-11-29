using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ProgramItemVocabulary : SimpleVocabulary
    {
        public ProgramItemVocabulary()
        {
            VocabularyName = "Program Item";
            KeyPrefix = "commonDataModel.programitem.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/ProgramItem";

            AddGroup("ProgramItem Details for NonProfitCore", group =>
            {
			    DateFulfilled = group.Add(new VocabularyKey(nameof(DateFulfilled), "Date Fulfilled", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObligationType = group.Add(new VocabularyKey(nameof(ObligationType), "Obligation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationType = group.Add(new VocabularyKey(nameof(ObservationType), "Observation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProgramItemId = group.Add(new VocabularyKey(nameof(ProgramItemId), "Program Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RatingType = group.Add(new VocabularyKey(nameof(RatingType), "Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubType = group.Add(new VocabularyKey(nameof(SubType), "SubType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DateFulfilled { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObligationType { get; private set; }
        public VocabularyKey ObservationType { get; private set; }
        public VocabularyKey ProgramItemId { get; private set; }
        public VocabularyKey RatingType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey SubType { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}