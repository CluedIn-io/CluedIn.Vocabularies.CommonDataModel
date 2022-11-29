using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class CollateralVocabulary : SimpleVocabulary
    {
        public CollateralVocabulary()
        {
            VocabularyName = "Collateral";
            KeyPrefix = "commonDataModel.collateral.banking";
            KeySeparator = ".";
            Grouping = "/Collateral";

            AddGroup("Collateral Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CollateralId = group.Add(new VocabularyKey(nameof(CollateralId), "Collateral", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollateralType = group.Add(new VocabularyKey(nameof(CollateralType), "Collateral Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollateralValue = group.Add(new VocabularyKey(nameof(CollateralValue), "Collateral Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CollateralValueBase = group.Add(new VocabularyKey(nameof(CollateralValueBase), "Collateral Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Coverage = group.Add(new VocabularyKey(nameof(Coverage), "Coverage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DateOfValuation = group.Add(new VocabularyKey(nameof(DateOfValuation), "Date of Valuation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EvaluatedBy = group.Add(new VocabularyKey(nameof(EvaluatedBy), "Evaluated by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextDateOfValuation = group.Add(new VocabularyKey(nameof(NextDateOfValuation), "Next Date of Valuation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CollateralId { get; private set; }
        public VocabularyKey CollateralType { get; private set; }
        public VocabularyKey CollateralValue { get; private set; }
        public VocabularyKey CollateralValueBase { get; private set; }
        public VocabularyKey Coverage { get; private set; }
        public VocabularyKey DateOfValuation { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EvaluatedBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextDateOfValuation { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
    }
}