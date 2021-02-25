using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Portfolio.Pages.Contents.Works;
using Portfolio.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System;
using Fluxor;
using Portfolio.Stores.ModalItems;

namespace Portfolio.Pages.SPA
{
    public partial class Works
    {
        #region ClassName State
        // pass classname parameter
        [Parameter] public string ClassName { get; set; }
        #endregion

        #region Modal
        // call Modal
        [CascadingParameter] public IModalService Modal { get; set; }

        void ShowModal(string appName, string displayName)
        {
            var opt = new ModalOptions()
            {
                ContentScrollable = true,
                FocusFirstElement = true
            };

            ChangeModalState(appName);

            Modal.Show<WorkDetails>(displayName, opt);
        }
        #endregion

        // fetch list data works
        public List<WorksVM> works;

        #region Pagination
        // pagination
        private decimal pageSize = 8;
        public int currentPage = 1;
        public bool PrevIsDisabled = false;
        public bool NextIsDisabled = false;
        public int totalPage = 1;
        public List<int> pages = new List<int>();

        public decimal test = 0;
        public decimal test1 = 0;

        private void SetPagination(decimal DataLength)
        {
            if (Convert.ToDecimal(DataLength / pageSize) < 1 || currentPage == 1)
            {
                PrevIsDisabled = true;
            }
            else
            {
                PrevIsDisabled = false;
            }

            if (Convert.ToDecimal(DataLength / pageSize) < 1 || 
                Math.Ceiling(Convert.ToDecimal(DataLength / pageSize)) <= (currentPage))
            {
                NextIsDisabled = true;
                Console.WriteLine("datalenght : " + Convert.ToDecimal(DataLength / pageSize));
                Console.WriteLine("datalenght1 : " + Math.Ceiling(Convert.ToDecimal(DataLength / pageSize)));
                Console.WriteLine("curpage : " + currentPage);
            }
            else
            {
                NextIsDisabled = false;
            }

            Console.WriteLine("PrevIsDisabled : " + PrevIsDisabled.ToString());
            Console.WriteLine("NextIsDisabled : " + NextIsDisabled.ToString());
        }
        #endregion

        protected override async Task OnInitializedAsync()
        {
            // reset state
            pages = new List<int>();

            // fetch list data works
            var res = await Http.GetFromJsonAsync<WorksVM[]>("sample-data/works.json");
            works = res.OrderBy(x => x.orderNo).Take(Convert.ToInt32(pageSize)).ToList();

            // get total pages
            totalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(res.Length / pageSize)));
            Console.WriteLine("On Initialized - TotalPage : " + totalPage.ToString());

            for (int i = 1; i <= totalPage; i++)
            {
                pages.Add(i);
            }

            // change pagination state
            SetPagination(Convert.ToDecimal(res.Length));
        }

        private async Task OnChangePage(int page)
        {
            // change page state
            currentPage = page;
            Console.WriteLine("On Change Page - currentPage : " + page.ToString());

            // fetch list data works
            var res = await Http.GetFromJsonAsync<WorksVM[]>("sample-data/works.json");
            works = res.OrderBy(x => x.orderNo).Skip((page - 1) * Convert.ToInt32(pageSize)).Take(Convert.ToInt32(pageSize)).ToList();

            // change pagination state
            SetPagination(Convert.ToDecimal(res.Length));
        }

        #region Modal state management
        // Modal state management
        [Inject]
        public IDispatcher _dispatcher { get; set; }

        private void ChangeModalState(string appName)
        {
            var data = new AppNameVM()
            {
                appName = appName
            };
            _dispatcher.Dispatch(new ModalPageChangeAction(data));

        }
        #endregion
    }
}
