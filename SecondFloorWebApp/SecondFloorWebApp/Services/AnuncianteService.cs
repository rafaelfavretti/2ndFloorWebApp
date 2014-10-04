using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using SecondFloorWebApp.IRepository;
using SecondFloorWebApp.Models;

namespace SecondFloorWebApp.Services
{
    public class AnuncianteService
    {
        private IAnuncianteRepository _anuncianteRepository;
        private IEnderecoRepository _enderecoRepository;
        private ILoginRepository _loginRepository;

        public AnuncianteService(IAnuncianteRepository anuncianteRepository, IEnderecoRepository enderecoRepository,
            ILoginRepository loginRepository)
        {
            _anuncianteRepository = anuncianteRepository;
            _enderecoRepository = enderecoRepository;
            _loginRepository = loginRepository;
        }

        public void CadastrarAnunciante(Anunciante anunciante, Collection<Endereco> enderecos )
        {
            _anuncianteRepository.insert(anunciante);

            foreach (var endereco in enderecos)
            {    
                _enderecoRepository.insert(endereco);
            }
        }

    }
}