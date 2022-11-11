using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetReservationTypeEntity_PSNVocabulary : SimpleVocabulary
    {
        public BudgetReservationTypeEntity_PSNVocabulary()
        {
            VocabularyName = "Common Data Model BudgetReservationTypeEntity_PSN";
            KeyPrefix = "commonDataModel.budgetreservationtypeentity_psn";
            KeySeparator = ".";
            Grouping = "/BudgetReservationTypeEntity_PSN";

            AddGroup("Common Data Model BudgetReservationTypeEntity_PSN Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationType = group.Add(new VocabularyKey(nameof(ReservationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReduceCarryForwardBudget = group.Add(new VocabularyKey(nameof(ReduceCarryForwardBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelievingDocument = group.Add(new VocabularyKey(nameof(RelievingDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Workflow = group.Add(new VocabularyKey(nameof(Workflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTableRecId = group.Add(new VocabularyKey(nameof(NumberSequenceTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReservationType { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey ReduceCarryForwardBudget { get; private set; }
        public VocabularyKey RelievingDocument { get; private set; }
        public VocabularyKey Workflow { get; private set; }
        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey NumberSequenceTableRecId { get; private set; }


    }
}