using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCollaborationWorkspaceSettingsEntityVocabulary : SimpleVocabulary
    {
        public ProjCollaborationWorkspaceSettingsEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCollaborationWorkspaceSettingsEntity";
            KeyPrefix = "commonDataModel.projcollaborationworkspacesettingsentity";
            KeySeparator = ".";
            Grouping = "/ProjCollaborationWorkspaceSettingsEntity";

            AddGroup("Common Data Model ProjCollaborationWorkspaceSettingsEntity Details", group =>
            {
                IsWorkspaceAutoCreatedForCost = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreatedForFixedPrice = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForFixedPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreatedForInternal = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForInternal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreatedForInvestment = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForInvestment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreated = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreatedForTime = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkspaceAutoCreatedForTimeMaterial = group.Add(new VocabularyKey(nameof(IsWorkspaceAutoCreatedForTimeMaterial), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessArea = group.Add(new VocabularyKey(nameof(BusinessArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatingWorkspacePrompted = group.Add(new VocabularyKey(nameof(IsCreatingWorkspacePrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeletingWorkspacePrompted = group.Add(new VocabularyKey(nameof(IsDeletingWorkspacePrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkspaceHomePage = group.Add(new VocabularyKey(nameof(WorkspaceHomePage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharePointVersion = group.Add(new VocabularyKey(nameof(SharePointVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreMSProjectFiles = group.Add(new VocabularyKey(nameof(StoreMSProjectFiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SyncTaskLists = group.Add(new VocabularyKey(nameof(SyncTaskLists), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Template = group.Add(new VocabularyKey(nameof(Template), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsWorkspaceAutoCreatedForCost { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreatedForFixedPrice { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreatedForInternal { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreatedForInvestment { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreated { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreatedForTime { get; private set; }
        public VocabularyKey IsWorkspaceAutoCreatedForTimeMaterial { get; private set; }
        public VocabularyKey BusinessArea { get; private set; }
        public VocabularyKey IsCreatingWorkspacePrompted { get; private set; }
        public VocabularyKey IsDeletingWorkspacePrompted { get; private set; }
        public VocabularyKey WorkspaceHomePage { get; private set; }
        public VocabularyKey SharePointVersion { get; private set; }
        public VocabularyKey StoreMSProjectFiles { get; private set; }
        public VocabularyKey SyncTaskLists { get; private set; }
        public VocabularyKey Template { get; private set; }


    }
}