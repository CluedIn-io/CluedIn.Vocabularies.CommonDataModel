using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class BookableResourceVocabulary : SimpleVocabulary
    {
        public BookableResourceVocabulary()
        {
            VocabularyName = "Bookable Resource";
            KeyPrefix = "commonDataModel.bookableresource.projectcommon";
            KeySeparator = ".";
            Grouping = "/BookableResource";

            AddGroup("BookableResource Details for ProjectCommon", group =>
            {
			    PoolType = group.Add(new VocabularyKey(nameof(PoolType), "Pool Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeriveCapacity = group.Add(new VocabularyKey(nameof(DeriveCapacity), "Derive Capacity From Group Members", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOnScheduleAssistant = group.Add(new VocabularyKey(nameof(DisplayOnScheduleAssistant), "Enable for Availability Search", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOnScheduleBoard = group.Add(new VocabularyKey(nameof(DisplayOnScheduleBoard), "Display On Schedule Board", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EndLocation = group.Add(new VocabularyKey(nameof(EndLocation), "End Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenericType = group.Add(new VocabularyKey(nameof(GenericType), "Generic Type (Deprecated)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryEMail = group.Add(new VocabularyKey(nameof(PrimaryEMail), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    StartLocation = group.Add(new VocabularyKey(nameof(StartLocation), "Start Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetUtilization = group.Add(new VocabularyKey(nameof(TargetUtilization), "Target Utilization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PoolType { get; private set; }
        public VocabularyKey DeriveCapacity { get; private set; }
        public VocabularyKey DisplayOnScheduleAssistant { get; private set; }
        public VocabularyKey DisplayOnScheduleBoard { get; private set; }
        public VocabularyKey EndLocation { get; private set; }
        public VocabularyKey GenericType { get; private set; }
        public VocabularyKey PrimaryEMail { get; private set; }
        public VocabularyKey StartLocation { get; private set; }
        public VocabularyKey TargetUtilization { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
    }
}