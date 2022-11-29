using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class DeliveryFrameworkVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkVocabulary()
        {
            VocabularyName = "Delivery Framework";
            KeyPrefix = "commonDataModel.deliveryframework.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/DeliveryFramework";

            AddGroup("DeliveryFramework Details for NonProfitCore", group =>
            {
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkId = group.Add(new VocabularyKey(nameof(DeliveryFrameworkId), "Delivery Framework", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkType = group.Add(new VocabularyKey(nameof(DeliveryFrameworkType), "Delivery Framework Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Goal = group.Add(new VocabularyKey(nameof(Goal), "Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedEndDate = group.Add(new VocabularyKey(nameof(PlannedEndDate), "Planned End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedStartDate = group.Add(new VocabularyKey(nameof(PlannedStartDate), "Planned Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scope = group.Add(new VocabularyKey(nameof(Scope), "Scope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Country { get; private set; }
        public VocabularyKey DeliveryFrameworkId { get; private set; }
        public VocabularyKey DeliveryFrameworkType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Goal { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlannedEndDate { get; private set; }
        public VocabularyKey PlannedStartDate { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey Scope { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}