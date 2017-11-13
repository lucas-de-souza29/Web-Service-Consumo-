using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;

namespace WebService_Aula14_Atividade8
{
    public partial class _Default : Page
    {
        HttpClient client;
        Uri instituicaoUri;

        public _Default()
        {
            if(client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://turmadobem.azurewebsites.net/api/instituicao");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                getAll();
            }
        }

        private void getAll()
        {
            //chamando a api pela url
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://turmadobem.azurewebsites.net/api/instituicao").Result;

           //se retornar com sucesso busca os dados 
            if(response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho 
                instituicaoUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável instituições
                var instituicoes = response.Content.ReadAsAsync<IEnumerable<Instituicao>>().Result;

                //preenchendo a lista com os dados retornados da variável 
                GridView1.DataSource = instituicoes;
                GridView1.DataBind();
            }
               //Se der erro na chamada, mostra o status do código de erro.
            else
            {
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
            }
        }
    }
}