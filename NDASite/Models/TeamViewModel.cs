using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NDASite.Models
{
    public class TeamViewModel
    {
        private List<BioViewModel> teamBios;

        public TeamViewModel()
        {
            teamBios = TeamBios;
        }

        public List<BioViewModel> TeamBios
        {
            get
            {
                teamBios = new List<BioViewModel>
                {
                    new BioViewModel {Id=1,Name= "Nick Diachenko", Title="President", Email="nickd@ndainc.net",Phone="(502) 495-2345",
                        Description="As co-founder of NDA, Inc., Nick Diachenko continues to lead the organization and the franchisee clients through successful brokerage services. As an outgrowth of their work with franchisees at KFC, in 1988, Nick and Charlie Nash launched NDA. Nick began working with franchisees in 1976 for Convenient Industries of America and two years later was chosen to run an in-house SBA-Licensed Small business Investment Company (SBIC) before being promoted to run the Franchising Department for Convenient Industries of America. In 1984, Nick joined KFC Corporation as Director of Franchise Development."
                    , ImageUrl="~/Content/nick.jpg"},
                    new BioViewModel {Id=2,Name= "John Pinar", Title="Associate", Email="johnp@ndainc.net",Phone="(502) 491-0424",
                        Description="In 2006, John brought to the NDA, Inc. team many years of experience in the restaurant industry and finance. He best serves his clients through building a relationship and working with them to sell their franchise. His career began at Walt Disney World as the Restaurant Manager and Financial Analyst. Later he held positions with Delta Airlines and Domino’s Pizza in finance. Before joining the NDA, Inc team, he was the Franchise Finance Manager for KFC Corporation. Each of these positions prepared John to contribute to the success of NDA’s clients.John earned his Bachelor of Science in Hotel and Restaurant Management from the University of Wisconsin - Stout; and his MBA from Rollins College."
                    , ImageUrl="~/Content/john.jpg"},
                    new BioViewModel {Id=3, Name= "Derek Diachenko", Title="Financial Analyst", Email="derekd@ndainc.net",Phone="(502) 495-2262",
                        Description="Derek’s primary role at NDA, Inc. is to analyse the financials throughout the franchise acquisition and divestiture process to ensure a stronger transaction and greater success for the client. Additionally, he has expertise in valuation and marketing current opportunities for franchisees to buy or sell. Derek is the NDA facilitator who handles the back office challenges getting to the goal line for our transactions. Prior to joining NDA in 2006, he worked at First Financal Mortgage as a mortgage broker. Derek earned his Bachelor of Arts degree in finance and marketing from the University of Kentucky."
                    , ImageUrl="~/Content/derek.jpg"},
                    new BioViewModel {Id=4,Name= "Byron Burge", Title="Associate", Email="byronb@ndainc.net",Phone="(502) 618-4895",
                        Description="Byron Burge brings 30 years of business development expertise and innovation to the NDA team. He is recognized nationally as a business development innovator who leads with strategy, effective communication, with a heavy emphasis on relationship building on both the buy and sell side. His executable planning gets results for clients. As a natural connector and strategic thinker, his deal making expertise ranges from creating succinct messaging, positioning and framing in national campaigns, to the implementation of a well-planned sales process to effectively attract impactful new clients. His approach is hands on, from the beginning of an engagement to finding the right buyer who is the best fit to acquire your restaurants. He excels in creating the dynamics that get impactful results."
                    , ImageUrl="~/Content/byron.jpg"},
                    new BioViewModel {Id=5,Name="Mitch Rue", Title="Associate", Email="mitchr@ndainc.net",Phone="(502) 618-4896",
                        Description="Mitch has over thirty years of sales, marketing and operations experience as a company owner, consultant, and organizational leader. He has held leadership roles in his own businesses, private organizations and public Fortune 500 organizations.  Mitch has been awarded for his achievements in business and volunteer roles. For 20+ years he was recognized for high levels of sales leadership achievement at Brown-Forman Corporation, a global beverage leader. Mitch owned a technology services organization before exiting to form a consultancy.  He brings to NDA a customer centric approach that delivers proven results for all parties while maintaining the highest level of integrity. Mitch currently serves as Chairman of the Board of Trustees for Blue Ridge School in St George, VA.Mitch also serves on the Board of Trustees of the Jefferson County Public Education Foundation."
                    , ImageUrl="~/Content/mitch.jpeg"},
                    new BioViewModel {Id=6, Name="John A. Newman", Title="CPA & Director",
                    Description="With the reorganization of NDA in 1994, John Newman joined NDA as the firm’s certified public accountant and a corporate director. John has worked with a variety of industries in addition to representing several restaurant owners as an accountant and advisor. His extensive knowledge of financial analysis, planning and strategy has proved to be beneficial to NDA’s growth.",
                    ImageUrl="~/Content/newman.jpg"}

                };

                return teamBios; 
            }
        }
    }
}