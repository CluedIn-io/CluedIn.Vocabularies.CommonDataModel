using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class BookableResourceAssociationVocabulary : SimpleVocabulary
    {
        public BookableResourceAssociationVocabulary()
        {
            VocabularyName = "Bookable Resource Association";
            KeyPrefix = "commonDataModel.bookableresourceassociation.scheduling";
            KeySeparator = ".";
            Grouping = "/BookableResourceAssociation";

            AddGroup("BookableResourceAssociation Details for Scheduling", group =>
            {
			    BookableresourceassociationId = group.Add(new VocabularyKey(nameof(BookableresourceassociationId), "Bookable Resource Association", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FromDate = group.Add(new VocabularyKey(nameof(FromDate), "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToDate = group.Add(new VocabularyKey(nameof(ToDate), "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookableresourceassociationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}