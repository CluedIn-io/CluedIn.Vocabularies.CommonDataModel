using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanWorksheetEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanWorksheetEntityVocabulary()
        {
            VocabularyName = "Budget Plan Worksheet Entity";
            KeyPrefix = "commonDataModel.budgetplanworksheetentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanWorksheetEntity";

            AddGroup("BudgetPlanWorksheetEntity Details", group =>
            {
                BudgetPlanHeader = group.Add(new VocabularyKey(nameof(BudgetPlanHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetClass = group.Add(new VocabularyKey(nameof(BudgetClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNewRequest = group.Add(new VocabularyKey(nameof(IsNewRequest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRecurring = group.Add(new VocabularyKey(nameof(IsRecurring), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataAreaId = group.Add(new VocabularyKey(nameof(SourceDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedAsset = group.Add(new VocabularyKey(nameof(ProposedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedProject = group.Add(new VocabularyKey(nameof(ProposedProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedAssetName = group.Add(new VocabularyKey(nameof(ProposedAssetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedAssetDescription = group.Add(new VocabularyKey(nameof(ProposedAssetDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedProjectName = group.Add(new VocabularyKey(nameof(ProposedProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedProjectDescription = group.Add(new VocabularyKey(nameof(ProposedProjectDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPosition = group.Add(new VocabularyKey(nameof(ForecastPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue1 = group.Add(new VocabularyKey(nameof(DimensionValue1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName1 = group.Add(new VocabularyKey(nameof(DimensionName1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue2 = group.Add(new VocabularyKey(nameof(DimensionValue2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName2 = group.Add(new VocabularyKey(nameof(DimensionName2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue3 = group.Add(new VocabularyKey(nameof(DimensionValue3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName3 = group.Add(new VocabularyKey(nameof(DimensionName3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue4 = group.Add(new VocabularyKey(nameof(DimensionValue4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName4 = group.Add(new VocabularyKey(nameof(DimensionName4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue5 = group.Add(new VocabularyKey(nameof(DimensionValue5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName5 = group.Add(new VocabularyKey(nameof(DimensionName5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue6 = group.Add(new VocabularyKey(nameof(DimensionValue6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName6 = group.Add(new VocabularyKey(nameof(DimensionName6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue7 = group.Add(new VocabularyKey(nameof(DimensionValue7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName7 = group.Add(new VocabularyKey(nameof(DimensionName7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue8 = group.Add(new VocabularyKey(nameof(DimensionValue8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName8 = group.Add(new VocabularyKey(nameof(DimensionName8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue9 = group.Add(new VocabularyKey(nameof(DimensionValue9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName9 = group.Add(new VocabularyKey(nameof(DimensionName9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue10 = group.Add(new VocabularyKey(nameof(DimensionValue10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName10 = group.Add(new VocabularyKey(nameof(DimensionName10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue11 = group.Add(new VocabularyKey(nameof(DimensionValue11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName11 = group.Add(new VocabularyKey(nameof(DimensionName11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount1 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount2 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount3 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount4 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount5 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount6 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount7 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount8 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount9 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount10 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount11 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount12 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount13 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount14 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount15 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount16 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount16), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount17 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount17), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount18 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount18), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount19 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount19), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount20 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount20), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount21 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount21), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount22 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount22), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount23 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount23), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount24 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount24), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount25 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount25), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount26 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount26), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount27 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount27), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount28 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount28), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount29 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount29), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount30 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount30), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount31 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount31), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount32 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount32), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount33 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount33), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount34 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount34), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount35 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount35), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount36 = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount36), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity1 = group.Add(new VocabularyKey(nameof(Quantity1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity2 = group.Add(new VocabularyKey(nameof(Quantity2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity3 = group.Add(new VocabularyKey(nameof(Quantity3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity4 = group.Add(new VocabularyKey(nameof(Quantity4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity5 = group.Add(new VocabularyKey(nameof(Quantity5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity6 = group.Add(new VocabularyKey(nameof(Quantity6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity7 = group.Add(new VocabularyKey(nameof(Quantity7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity8 = group.Add(new VocabularyKey(nameof(Quantity8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity9 = group.Add(new VocabularyKey(nameof(Quantity9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity10 = group.Add(new VocabularyKey(nameof(Quantity10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity11 = group.Add(new VocabularyKey(nameof(Quantity11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity12 = group.Add(new VocabularyKey(nameof(Quantity12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity13 = group.Add(new VocabularyKey(nameof(Quantity13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity14 = group.Add(new VocabularyKey(nameof(Quantity14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity15 = group.Add(new VocabularyKey(nameof(Quantity15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity16 = group.Add(new VocabularyKey(nameof(Quantity16), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity17 = group.Add(new VocabularyKey(nameof(Quantity17), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity18 = group.Add(new VocabularyKey(nameof(Quantity18), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity19 = group.Add(new VocabularyKey(nameof(Quantity19), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity20 = group.Add(new VocabularyKey(nameof(Quantity20), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity21 = group.Add(new VocabularyKey(nameof(Quantity21), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity22 = group.Add(new VocabularyKey(nameof(Quantity22), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity23 = group.Add(new VocabularyKey(nameof(Quantity23), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity24 = group.Add(new VocabularyKey(nameof(Quantity24), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity25 = group.Add(new VocabularyKey(nameof(Quantity25), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity26 = group.Add(new VocabularyKey(nameof(Quantity26), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity27 = group.Add(new VocabularyKey(nameof(Quantity27), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity28 = group.Add(new VocabularyKey(nameof(Quantity28), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity29 = group.Add(new VocabularyKey(nameof(Quantity29), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity30 = group.Add(new VocabularyKey(nameof(Quantity30), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity31 = group.Add(new VocabularyKey(nameof(Quantity31), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity32 = group.Add(new VocabularyKey(nameof(Quantity32), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity33 = group.Add(new VocabularyKey(nameof(Quantity33), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity34 = group.Add(new VocabularyKey(nameof(Quantity34), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity35 = group.Add(new VocabularyKey(nameof(Quantity35), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity36 = group.Add(new VocabularyKey(nameof(Quantity36), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanLayout = group.Add(new VocabularyKey(nameof(BudgetPlanLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetIdDescription = group.Add(new VocabularyKey(nameof(AssetIdDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectIdDescription = group.Add(new VocabularyKey(nameof(ProjectIdDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDescription = group.Add(new VocabularyKey(nameof(PositionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionWorkerName = group.Add(new VocabularyKey(nameof(PositionWorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BudgetPlanHeader { get; private set; }
        public VocabularyKey BudgetClass { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey IsNewRequest { get; private set; }
        public VocabularyKey IsRecurring { get; private set; }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey SourceDataAreaId { get; private set; }
        public VocabularyKey ProposedAsset { get; private set; }
        public VocabularyKey ProposedProject { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey ProposedAssetName { get; private set; }
        public VocabularyKey ProposedAssetDescription { get; private set; }
        public VocabularyKey ProposedProjectName { get; private set; }
        public VocabularyKey ProposedProjectDescription { get; private set; }
        public VocabularyKey ForecastPosition { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey DimensionValue1 { get; private set; }
        public VocabularyKey DimensionName1 { get; private set; }
        public VocabularyKey DimensionValue2 { get; private set; }
        public VocabularyKey DimensionName2 { get; private set; }
        public VocabularyKey DimensionValue3 { get; private set; }
        public VocabularyKey DimensionName3 { get; private set; }
        public VocabularyKey DimensionValue4 { get; private set; }
        public VocabularyKey DimensionName4 { get; private set; }
        public VocabularyKey DimensionValue5 { get; private set; }
        public VocabularyKey DimensionName5 { get; private set; }
        public VocabularyKey DimensionValue6 { get; private set; }
        public VocabularyKey DimensionName6 { get; private set; }
        public VocabularyKey DimensionValue7 { get; private set; }
        public VocabularyKey DimensionName7 { get; private set; }
        public VocabularyKey DimensionValue8 { get; private set; }
        public VocabularyKey DimensionName8 { get; private set; }
        public VocabularyKey DimensionValue9 { get; private set; }
        public VocabularyKey DimensionName9 { get; private set; }
        public VocabularyKey DimensionValue10 { get; private set; }
        public VocabularyKey DimensionName10 { get; private set; }
        public VocabularyKey DimensionValue11 { get; private set; }
        public VocabularyKey DimensionName11 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount1 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount2 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount3 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount4 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount5 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount6 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount7 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount8 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount9 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount10 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount11 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount12 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount13 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount14 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount15 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount16 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount17 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount18 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount19 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount20 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount21 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount22 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount23 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount24 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount25 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount26 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount27 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount28 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount29 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount30 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount31 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount32 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount33 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount34 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount35 { get; private set; }
        public VocabularyKey TransactionCurrencyAmount36 { get; private set; }
        public VocabularyKey Quantity1 { get; private set; }
        public VocabularyKey Quantity2 { get; private set; }
        public VocabularyKey Quantity3 { get; private set; }
        public VocabularyKey Quantity4 { get; private set; }
        public VocabularyKey Quantity5 { get; private set; }
        public VocabularyKey Quantity6 { get; private set; }
        public VocabularyKey Quantity7 { get; private set; }
        public VocabularyKey Quantity8 { get; private set; }
        public VocabularyKey Quantity9 { get; private set; }
        public VocabularyKey Quantity10 { get; private set; }
        public VocabularyKey Quantity11 { get; private set; }
        public VocabularyKey Quantity12 { get; private set; }
        public VocabularyKey Quantity13 { get; private set; }
        public VocabularyKey Quantity14 { get; private set; }
        public VocabularyKey Quantity15 { get; private set; }
        public VocabularyKey Quantity16 { get; private set; }
        public VocabularyKey Quantity17 { get; private set; }
        public VocabularyKey Quantity18 { get; private set; }
        public VocabularyKey Quantity19 { get; private set; }
        public VocabularyKey Quantity20 { get; private set; }
        public VocabularyKey Quantity21 { get; private set; }
        public VocabularyKey Quantity22 { get; private set; }
        public VocabularyKey Quantity23 { get; private set; }
        public VocabularyKey Quantity24 { get; private set; }
        public VocabularyKey Quantity25 { get; private set; }
        public VocabularyKey Quantity26 { get; private set; }
        public VocabularyKey Quantity27 { get; private set; }
        public VocabularyKey Quantity28 { get; private set; }
        public VocabularyKey Quantity29 { get; private set; }
        public VocabularyKey Quantity30 { get; private set; }
        public VocabularyKey Quantity31 { get; private set; }
        public VocabularyKey Quantity32 { get; private set; }
        public VocabularyKey Quantity33 { get; private set; }
        public VocabularyKey Quantity34 { get; private set; }
        public VocabularyKey Quantity35 { get; private set; }
        public VocabularyKey Quantity36 { get; private set; }
        public VocabularyKey BudgetPlanLayout { get; private set; }
        public VocabularyKey Layout { get; private set; }
        public VocabularyKey AssetIdDescription { get; private set; }
        public VocabularyKey ProjectIdDescription { get; private set; }
        public VocabularyKey PositionDescription { get; private set; }
        public VocabularyKey PositionWorkerName { get; private set; }
    }
}