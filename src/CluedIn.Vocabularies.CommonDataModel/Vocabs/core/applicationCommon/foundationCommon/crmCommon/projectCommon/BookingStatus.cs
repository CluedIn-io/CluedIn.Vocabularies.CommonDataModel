using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class BookingStatusVocabulary : SimpleVocabulary
    {
        public BookingStatusVocabulary()
        {
            VocabularyName = "Booking Status";
            KeyPrefix = "commonDataModel.bookingstatus.projectcommon";
            KeySeparator = ".";
            Grouping = "/BookingStatus";

            AddGroup("BookingStatus Details for ProjectCommon", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageURL = group.Add(new VocabularyKey(nameof(ImageURL), "Image Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StatusColor = group.Add(new VocabularyKey(nameof(StatusColor), "Status Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitType = group.Add(new VocabularyKey(nameof(CommitType), "Commit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ImageURL { get; private set; }
        public VocabularyKey StatusColor { get; private set; }
        public VocabularyKey CommitType { get; private set; }
    }
}