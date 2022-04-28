package com.example.projetoagenda;

public class PersonagemDAO {

    private final static List<Personagem> personagens = new ArrayList<>();
    private static int contadorDeIds = 1;

    public void salva(Personagem personagemSalvo) {
        personagemSalvo.setId(contadorDeIds);
        personagens.add(personagemSalvo);
        atualizaId();
    }
    private void atualizaId() { contadorDeIds++;}

    public void edita(Personagem personagem){
        Personagem personagemEncontrado = buscaPersonagemId(personagem);
        if (personagemEncontrado != null){
            int posicaoDoPersonagem = personagem.indexOf(personagemEncontrado);
            personagens.set(posicaoDoPersonagem, personagem);
        }
    }
}
