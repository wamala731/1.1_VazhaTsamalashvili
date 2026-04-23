using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Application.IServices
{
    public interface IHelpServices
    {
        public void returnRemainingHelps();
        public void useFiftyFiftyHelp(Question question);
        public void usePhoneAFriendHelp(Question question);
        public void useAskTheAudienceHelp(Question question);
        public void useHelp(Question question, out string usedHelp);
    }
}
