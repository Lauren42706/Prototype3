using Prototype2WebApi.Models;

namespace Prototype2WebApi.Interfaces
{
    public interface IPrototypeDbRepository
    {
        UserInfoData CreateNewUser(UserInfoData data);
        Schedule CreateNewSchedule(Schedule schedule);
        List<Schedule> GetAllSchedules(bool fullFetch = true);
        List<PostedStory> GetAllPostedStories(bool fullFetch = true);
        PostedStory PostStory(PostedStory postedstory);
        Schedule GetScheduleId(int id, bool fullFetch = true);
        PostedStory GetPostedStoryId(int id, bool fullFetch = true);
        public bool DoesUserExistById(int id);
        public bool DoesScheduleExistById(int id);
        public bool DoesPostedStoryExistById(int id);
        public bool DoesUserExistByEmail(string email);
        UserInfoData GetUserById(int id);
        UserInfoData GetCustomerByFirstName(string firstname);
        UserInfoData GetCustomerByLastName(string lastname);
        UserInfoData GetCustomerByEmail(string email);
        UserInfoData GetCustomerByCell(string cell);
        UserInfoData GetCustomerByPassword(string password);
        public List<UserInfoData> GetUserInfoData();
        public Acheivement CreateNewAcheivement(Acheivement acheivement);
        public List<Acheivement> GetAllAcheivements();
        public Acheivement GetAcheivementById(int id);
        public FamilyGroup CreateFamilyGroup(FamilyGroup famgroup);
        public bool DoesFamilyGroupExistById(int id);
        public List<FamilyGroup> GetAllFamilyMembers();
        public FamilyGroup GetFamilyGroupById(int id);
        public FamilyStatus CreateFamilyStatus(FamilyStatus famstatus);
        public bool DoesFamilyStatusExistById(int id);
        public List<FamilyStatus> GetAllFamilyStatuses();
        public FamilyStatus GetFamilyStatusById(int id);
        Discussion CreateNewDiscussion(Discussion discussion);
        public Discussion GetDiscussionById(int id);
        List<Discussion> GetDiscussion();
        Avatar CreateNewAvatar(Avatar avatar);
        List<Avatar> GetAvatarData();
        public Avatar GetAvatarById(int id);
        Following CreateNewFollower(Following following);
        List<Following> GetUserFollowerData();
        public Following GetFollowerById(int id);
        public bool DoesFollowerExistById(int id);
        public bool PerformAuthenticationCheck(string userName, string pin);
    }
}
