using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DataRequirementDateFilterVocabulary : SimpleVocabulary
    {
        public DataRequirementDateFilterVocabulary()
        {
            VocabularyName = "Data Requirement Date Filter";
            KeyPrefix = "commonDataModel.datarequirementdatefilter.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DataRequirementDateFilter";

            AddGroup("DataRequirementDateFilter Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataRequirementDateFilterId = group.Add(new VocabularyKey(nameof(DataRequirementDateFilterId), "Data Requirement Date Filter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateFilterPath = group.Add(new VocabularyKey(nameof(DateFilterPath), "Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateFilterValueDateTime = group.Add(new VocabularyKey(nameof(DateFilterValueDateTime), "Value Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateFilterValueDuration = group.Add(new VocabularyKey(nameof(DateFilterValueDuration), "Value Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DateFilterValuePeriodEnd = group.Add(new VocabularyKey(nameof(DateFilterValuePeriodEnd), "Value Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateFilterValuePeriodStart = group.Add(new VocabularyKey(nameof(DateFilterValuePeriodStart), "Value Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateFilterValueType = group.Add(new VocabularyKey(nameof(DateFilterValueType), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey DataRequirementDateFilterId { get; private set; }
        public VocabularyKey DateFilterPath { get; private set; }
        public VocabularyKey DateFilterValueDateTime { get; private set; }
        public VocabularyKey DateFilterValueDuration { get; private set; }
        public VocabularyKey DateFilterValuePeriodEnd { get; private set; }
        public VocabularyKey DateFilterValuePeriodStart { get; private set; }
        public VocabularyKey DateFilterValueType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}