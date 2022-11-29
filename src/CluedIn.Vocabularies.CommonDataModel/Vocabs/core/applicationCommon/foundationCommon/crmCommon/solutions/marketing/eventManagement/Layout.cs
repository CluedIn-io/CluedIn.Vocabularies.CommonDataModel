using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class LayoutVocabulary : SimpleVocabulary
    {
        public LayoutVocabulary()
        {
            VocabularyName = "Layout";
            KeyPrefix = "commonDataModel.layout.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Layout";

            AddGroup("Layout Details for EventManagement", group =>
            {
			    LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), "Layout", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Capacity = group.Add(new VocabularyKey(nameof(Capacity), "Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), "Disabled access", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisabledCapacity = group.Add(new VocabularyKey(nameof(DisabledCapacity), "Disabled capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FloorPlan = group.Add(new VocabularyKey(nameof(FloorPlan), "Floor Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Units = group.Add(new VocabularyKey(nameof(Units), "Units", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UsableArea = group.Add(new VocabularyKey(nameof(UsableArea), "Usable area", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LayoutId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey DisabledCapacity { get; private set; }
        public VocabularyKey FloorPlan { get; private set; }
        public VocabularyKey Units { get; private set; }
        public VocabularyKey UsableArea { get; private set; }
    }
}