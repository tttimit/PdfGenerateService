using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PdfGenerateService
{
    public class FormDataItems
    {
        [Key]
        public string user_id{get; set;}
        public string Name_fam { get; set; }
        public string Name_giv { get; set; }
        public string Dob { get; set; }
        public string Birth_town { get; set; }
        public string Birth_cntry { get; set; }
        public string Relations { get; set; }
        public string Pass_no { get; set; }
        public string Pass_cntry { get; set; }
        public string Ident_no { get; set; }
        public string Ident_cntry { get; set; }
        public string Cit { get; set; }
        public string Resi_tr { get; set; }
        public string Resi_sub { get; set; }
        public string Resi_cntry { get; set; }
        public string Resi_pc { get; set; }
        public string Corresp_str { get; set; }
        public string Corresp_sub { get; set; }
        public string Corresp_cntry { get; set; }
        public string Corresp_hap { get; set; }
        public string Off_ph_cc { get; set; }
        public string Off_ph_ac { get; set; }
        public string Off_ph { get; set; }
        public string After_ph_cc { get; set; }
        public string After_ph_ac { get; set; }
        public string Off_pn { get; set; }
        public string Com_dimia { get; set; }
        public string Fax_cc { get; set; }
        public string Fax_ac { get; set; }
        public string Fax_ph { get; set; }
        public string Email { get; set; }
        public string File_np { get; set; }
    }
}
