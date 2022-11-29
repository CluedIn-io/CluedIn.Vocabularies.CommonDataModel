using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ResourceAssignmentVocabulary : SimpleVocabulary
    {
        public ResourceAssignmentVocabulary()
        {
            VocabularyName = "Resource Assignment";
            KeyPrefix = "commonDataModel.resourceassignment.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ResourceAssignment";

            AddGroup("ResourceAssignment Details for ProjectServiceAutomation", group =>
            {
			    ResourceAssignmentId = group.Add(new VocabularyKey(nameof(ResourceAssignmentId), "Resource Assignment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitType = group.Add(new VocabularyKey(nameof(CommitType), "Commit Type (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FromDate = group.Add(new VocabularyKey(nameof(FromDate), "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Hours = group.Add(new VocabularyKey(nameof(Hours), "Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MSProjectClientId = group.Add(new VocabularyKey(nameof(MSProjectClientId), "MS Project Client Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedCost = group.Add(new VocabularyKey(nameof(PlannedCost), "Planned Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PlannedcostBase = group.Add(new VocabularyKey(nameof(PlannedcostBase), "Planned Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedCostContour = group.Add(new VocabularyKey(nameof(PlannedCostContour), "Planned Cost Contour", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedSales = group.Add(new VocabularyKey(nameof(PlannedSales), "Planned Sales", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlannedSalesBase = group.Add(new VocabularyKey(nameof(PlannedSalesBase), "Planned Sales (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedSalesContour = group.Add(new VocabularyKey(nameof(PlannedSalesContour), "Planned Sales Contour", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedWork = group.Add(new VocabularyKey(nameof(PlannedWork), "Planned Work", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToDate = group.Add(new VocabularyKey(nameof(ToDate), "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UserResourceId = group.Add(new VocabularyKey(nameof(UserResourceId), "Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceAssignmentId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CommitType { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey MSProjectClientId { get; private set; }
        public VocabularyKey PlannedCost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey PlannedcostBase { get; private set; }
        public VocabularyKey PlannedCostContour { get; private set; }
        public VocabularyKey PlannedSales { get; private set; }
        public VocabularyKey PlannedSalesBase { get; private set; }
        public VocabularyKey PlannedSalesContour { get; private set; }
        public VocabularyKey PlannedWork { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey UserResourceId { get; private set; }
    }
}