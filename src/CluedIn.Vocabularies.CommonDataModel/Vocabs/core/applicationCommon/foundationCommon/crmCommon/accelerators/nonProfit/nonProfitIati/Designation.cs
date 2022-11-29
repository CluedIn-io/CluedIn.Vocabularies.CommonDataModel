using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DesignationVocabulary : SimpleVocabulary
    {
        public DesignationVocabulary()
        {
            VocabularyName = "Designation";
            KeyPrefix = "commonDataModel.designation.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Designation";

            AddGroup("Designation Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcknowledgementName = group.Add(new VocabularyKey(nameof(AcknowledgementName), "Acknowledgement Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignationCode = group.Add(new VocabularyKey(nameof(DesignationCode), "Designation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignationGroup = group.Add(new VocabularyKey(nameof(DesignationGroup), "Designation Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignationId = group.Add(new VocabularyKey(nameof(DesignationId), "Designation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndowmentType = group.Add(new VocabularyKey(nameof(EndowmentType), "Endowment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GlCreditAccount = group.Add(new VocabularyKey(nameof(GlCreditAccount), "GL Credit Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GlDebitAccount = group.Add(new VocabularyKey(nameof(GlDebitAccount), "GL Debit Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Initiative = group.Add(new VocabularyKey(nameof(Initiative), "Initiative", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsActive = group.Add(new VocabularyKey(nameof(IsActive), "Is Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Program = group.Add(new VocabularyKey(nameof(Program), "Program", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionType = group.Add(new VocabularyKey(nameof(RestrictionType), "Restriction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDisbursed = group.Add(new VocabularyKey(nameof(TotalDisbursed), "Total Disbursed", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDisbursed_Base = group.Add(new VocabularyKey(nameof(TotalDisbursed_Base), "Total Disbursed (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey AcknowledgementName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DesignationCode { get; private set; }
        public VocabularyKey DesignationGroup { get; private set; }
        public VocabularyKey DesignationId { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey EndowmentType { get; private set; }
        public VocabularyKey GlCreditAccount { get; private set; }
        public VocabularyKey GlDebitAccount { get; private set; }
        public VocabularyKey Initiative { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Program { get; private set; }
        public VocabularyKey RestrictionType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalDisbursed { get; private set; }
        public VocabularyKey TotalDisbursed_Base { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}