using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramos {
    public Fala historia = new Fala(
        "01",
        Status.Nulo,
        new List<string> {"Certo dia, eu estava me sentindo muito GANANCIOSO, então saí para roubar. Nesse dia, eu tinha uma..."},
        Proximo.Escolha,
        new List<int> {},
        new List<string> {
            "Faca"
        },
        new List<Fala>{
            new Fala(
                "Faca",
                Status.Nulo,
                new List<string> {
                    "... faca! Afinal de contas, todos sabemos que a faca AK-47 é a faca ideal para combates e assaltos!",
                    "Essa faca foi muito útil, pois eu a usei para..."
                },
                Proximo.Escolha,
                new List<int> {},
                new List<string> {
                    "Cortar a bolsa",
                    "Ameaçar"
                },
                new List<Fala>{
                    new Fala(
                        "Cortar a Bolsa",
                        Status.Nulo,
                        new List<string> {
                            "Para cortar a bolsa dela! Tentei com isso roubar o celular dela."
                        },
                        Proximo.Probabilistico,
                        new List<int> {33,33,34},
                        new List<string> {},
                        new List<Fala> {
                            new Fala (
                                "Celular toca",
                                Status.Nulo,
                                new List<string> {
                                    "Foi então que o celular dela tocou. É claro que eu..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {
                                    "Atendi o celular",
                                    "Ameacei a pessoa"
                                },
                                new List<Fala> {
                                    new Fala (
                                        "Atendi o celular",
                                        Status.Nulo,
                                        new List<string> {
                                            "... fingi que o celular era meu e atendi o telefone.",
                                            "Mas quando eu disse \"alô?\"..."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {30,60,10},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "traido",
                                                Status.Falha,
                                                new List<string> {
                                                    "Percebi que era a minha namorada e descubri que estava sendo traído!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "Avó da vítima",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Vi que quem estava falando era a avó dele!",
                                                    "Ela me achou muito querido, então fez um pix para mim."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "Demo",
                                                Status.Falha,
                                                new List<string> {
                                                    "Eu ouvi um demônio que dizia:",
                                                    "vOCê tEm SetE DIaS"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }
                                    ),
                                    new Fala(
                                        "Ameacei ele com a minha faca",
                                        Status.Nulo,
                                        new List<string> {
                                            "... ameacei ele com a minha faca!"
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {60,40},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "Policial",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas ele era um policial e me deu um tiro na mesma hora!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "Intimidou",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Ele se intimidou com a AK-47, me deu tudo e saiu correndo!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }                
                                    )
                                }
                            ),
                            new Fala (
                                "Tropeçar",
                                Status.Nulo,
                                new List<string> {
                                    "Foi então que eu tropecei numa pedra no meio do caminho!",
                                    "Quando eu caí no chão, a pessoa tentou me ajudar ..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {
                                    "Aceitar",
                                    "Não aceitar"
                                },
                                new List<Fala> {
                                    new Fala (
                                        "aceitar",
                                        Status.Nulo,
                                        new List<string> {
                                            "... e é claro que eu aceitei a ajuda."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {34,33,33},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "roubo reverso",
                                                Status.Falha,
                                                new List<string> {
                                                    "Só que ele também era um ladrão! Ele se aproveitou de que eu estava vulnerável...",
                                                    "E roubou meu celular E minha carteira!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "SanZung Explode",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas enquanto ele tentava me ajudar, ele deixou o celular dele cair...",
                                                    "... o celular dele era um SanZung. Ao encostar no chão, ele explodiu...",
                                                    "... e todo mundo morreu."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "Nokia 3310",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas enquanto ele tentava me ajudar, ele deixou o celular dele cair...",
                                                    "... o celular dele era um Nóquia 3310. Ao encostar no chão, o mundo quebrou e a Terra implodiu...",
                                                    "... e todo mundo morreu."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }
                                    ),
                                    new Fala (
                                        "Não aceitar",
                                        Status.Nulo,
                                        new List<string> {
                                            "... mas eu não aceitei que ele me ajudasse.",
                                            "Eu queria fazer as coisas sozinho, já que eu estava me sentindo GANANCIOSO."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {30,25,25,20},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "salvei alguém",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Foi então que eu percebi que esbarrei com outra pessoa na queda.",
                                                    "Percebi também que eu tinha salvado ela de ser atropelada por um ônibus!",
                                                    "A pessoa se sentiu muito grata e me deu muito dinheiro para agradecer."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "SanZung Explode",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas enquanto ele me oferecia ajuda, ele deixou o celular dele cair...",
                                                    "... o celular dele era um SanZung. Ao encostar no chão, ele explodiu...",
                                                    "... e todo mundo morreu."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "Nokia 3310",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas enquanto ele me oferecia ajuda, ele deixou o celular dele cair...",
                                                    "... o celular dele era um Nóquia 3310. Ao encostar no chão, o mundo quebrou e a Terra implodiu...",
                                                    "... e todo mundo morreu."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "Breakdance",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Afinal, eu sou um ótimo dancarino!",
                                                    "Então consegui disfarçar o tropeço com um passo de breakdance!",
                                                    "Ele ficou impressionado com minha habilidade e me deu dinheiro pelo show!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }
                                    )
                                }
                            ),
                            new Fala (
                                "Pega normalmente",
                                Status.Nulo,
                                new List<string> {
                                    "Claro, com minhas habilidades, eu consegui roubar o celular da pessoa sem problemas.",
                                    "Pra falar a verdade, ele nem percebeu!",
                                    "Então, eu..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {"Fui embora", "Roubei mais"},
                                new List<Fala> {
                                    new Fala (
                                        "Sair de fininho",
                                        Status.Nulo,
                                        new List<string> {
                                            "... decidi jogar seguro e sair de fininho."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "saí de fininho-s",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Então fui embora e vendi o celular dele por muito dinheiro!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "SanZung Explode",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas enquanto eu estava saindo, eu deixei o celular dele cair...",
                                                    "... o celular dele era um SanZung. Ao encostar no chão, ele explodiu...",
                                                    "... e todo mundo morreu."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            )
                                        }
                                    ),
                                    new Fala(
                                        "Roubei mais",
                                        Status.Nulo,
                                        new List<string> {
                                            "... decidi tentar pegar também a carteira dele!",
                                            "Afinal, eu estava me sentindo GANANCIOSO!"
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "Ele percebeu",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas quando eu fui pegar a carteira, ele percebeu!",
                                                    "Depois ele me derrubou, pegou tudo de volta e saiu correndo..."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "Amigo de infância",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Mas quando eu peguei a carteira, percebi que era meu amigo de infância!",
                                                    "Tivemos um grande reencontro emotivo! Conversamos muito e ele me deu um emprego!"
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                        }
                                    )
                                }
                            )
                        }
                    ),
                    new Fala(
                        "Ameaçar",
                        Status.Nulo,
                        new List<string> {
                            "Para ameaçar ele! Afinal, a faca AK-47 é MUITO intimidadora."
                        },
                        Proximo.Probabilistico,
                        new List<int> {33,33,34},
                        new List<string> {},
                        new List<Fala> {
                            new Fala (
                                "FIGHT",
                                Status.Nulo,
                                new List<string> {
                                    "Mas ele TAMBÉM tinha a faca AK-47 - a faca perfeita para o combate.",
                                    "Então, eu decidi..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {
                                    "Atacar",
                                    "Esperar",
                                    "SASUKEEEEEEEE"
                                },
                                new List<Fala> {
                                    new Fala (
                                        "Atacar",
                                        Status.Nulo,
                                        new List<string> {
                                            "... atacar primeiro."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {30,30,40},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "desvia",
                                                Status.Falha,
                                                new List<string> {
                                                    "Saí correndo para dar uma facada nele, mas...",
                                                    "... ele desviou, faz um corte no meu braço e saiu correndo."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "pega",
                                                Status.Falha,
                                                new List<string> {
                                                    "Eu joguei a faca nele, mas ele a agarrou no ar!",
                                                    "Então ele pegou a mochila e saiu andando."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "defende",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Eu joguei a faca nele, mas ele se defendeu com a mochila!",
                                                    "A faca cortou a mochila dele e os pertences caíram, então...",
                                                    "... eu peguei tudo e saí correndo!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }
                                    ),
                                    new Fala(
                                        "Esperei",
                                        Status.Nulo,
                                        new List<string> {
                                            "... esperar ele atacar!"
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "ninja",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "O cara segurou a faca entre os dentes...",
                                                    "... e veio fazendo uma corrida ninja para cima de mmim!",
                                                    "Eu me defendi e consegui pegar a mochila que ele deixou parada."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "fuga",
                                                Status.Falha,
                                                new List<string> {
                                                    "Ele jogou a faca em minha direção, mas eu desviei por pouco.",
                                                    "Nesse tempo, a pessoa consegue fugir."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }                
                                    ),
                                    new Fala(
                                        "Sasuke",
                                        Status.Nulo,
                                        new List<string> {
                                            "... gritei \"SASUKEEEEEEE\"!"
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {100},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "Naruto",
                                                Status.Falha,
                                                new List<string> {
                                                    "O inimigo gritou NARUTOOOOO e nós lutamos até nos cansarem...",
                                                    "... e ele fogiu sem a bandana."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            )
                                        }                
                                    )
                                }
                            ),
                            new Fala (
                                "medo",
                                Status.Nulo,
                                new List<string> {
                                    "Então ele ficou com medo e abriu a bolsa pra me dar as coisas",
                                    "então eu..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {
                                    "Pedi tudo",
                                    "Ofereci ajuda"
                                },
                                new List<Fala> {
                                    new Fala (
                                        "Passa tudo",
                                        Status.Nulo,
                                        new List<string> {
                                            "... disse: \"passa rápido\"."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {40,60},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "Final Normal",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Ele me deu as coisas e eu fuji, como em um assalto normal..."
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "Nerf",
                                                Status.Nulo,
                                                new List<string> {
                                                    "Então ele tirou uma arma nerf da mala e disse:",
                                                    "\"Vai encarar?\""
                                                },
                                                Proximo.Escolha,
                                                new List<int>{},
                                                new List<string> {"Encarar", "Não encarar"},
                                                new List<Fala>{
                                                    new Fala (
                                                        "Encarei",
                                                        Status.Nulo,
                                                        new List<string> {
                                                            "Eu encarei."
                                                        },
                                                        Proximo.Probabilistico,
                                                        new List<int> {50,50},
                                                        new List<string> {},
                                                        new List<Fala> {
                                                            new Fala (
                                                                "nerf no olho",
                                                                Status.Falha,
                                                                new List<string> {
                                                                    "Então, ele acertou uma bala de nerf no meu olho e saiu correndo."
                                                                },
                                                                Proximo.NDA,
                                                                new List<int> {},
                                                                new List<string> {},
                                                                new List<Fala> {}
                                                            ),
                                                            new Fala (
                                                                "diversão com nerf",
                                                                Status.Falha,
                                                                new List<string> {
                                                                    "Então, ele me deu outra arma de nerf, nós brincamos e nos divertimos.",
                                                                    "Aí eu me esqueci do assalto."
                                                                },
                                                                Proximo.NDA,
                                                                new List<int> {},
                                                                new List<string> {},
                                                                new List<Fala> {}
                                                            )
                                                        }
                                                    ),
                                                    new Fala (
                                                        "Nao encarei",
                                                        Status.Falha,
                                                        new List<string> {
                                                            "Ele tinha uma nerf, é muito mais perigoso que eu e minha AK-47."
                                                        },
                                                        Proximo.NDA,
                                                        new List<int> {},
                                                        new List<string> {},
                                                        new List<Fala> {}
                                                    )
                                                }
                                            )
                                        }
                                    ),
                                    new Fala (
                                        "Oferece ajuda",
                                        Status.Nulo,
                                        new List<string> {
                                            "... ofereci ajuda para arrumar as coisas dele.",
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "ele aceitou",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Ele aceitou, me agradeceu e nós acabamos nos tornando bem amigos!",
                                                    "Ele até me deu um emprego!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala> {}
                                            ),
                                            new Fala (
                                                "ele me fez de trouxa",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas aí ele me fez de trouxa enquanto eu não prestava atenção...",
                                                    "... ele pegou minha faca e me ameaçou."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            )
                                        }
                                    )
                                }
                            ),
                            new Fala (
                                "sinistro",
                                Status.Nulo,
                                new List<string> {
                                    "A pessoa virou-se lentamente com um olhar calmo e me encarou sem parar e sem medo algum.",
                                    "Vendo isso, eu..."
                                },
                                Proximo.Escolha,
                                new List<int> {},
                                new List<string> {"Desisti do assalto", "Continuei encarando"},
                                new List<Fala> {
                                    new Fala (
                                        "Desisti",
                                        Status.Nulo,
                                        new List<string> {
                                            "... desisti de assaltar ele.",
                                            "Ele dá medo"
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "assalto reverso",
                                                Status.Falha,
                                                new List<string> {
                                                    "Eu decidi sair correndo, mas ele saiu atrás, e acabou me assaltando!"
                                                },
                                                Proximo.NDA,
                                                new List<int> {},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "Famoso",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Eu saí correndo, encontrei um policial que me ajudou com a pessoa.",
                                                    "O policial me protegeu e fiquei na internet, ganhando muito dinheiro."
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            )
                                        }
                                    ),
                                    new Fala(
                                        "Continuei encarando",
                                        Status.Nulo,
                                        new List<string> {
                                            "... continuei encarando ele."
                                        },
                                        Proximo.Probabilistico,
                                        new List<int> {50,50},
                                        new List<string> {},
                                        new List<Fala> {
                                            new Fala (
                                                "Olho azul",
                                                Status.Falha,
                                                new List<string> {
                                                    "Mas aí o olho do cara começa a brilhar azul...",
                                                    "e eu percebi que eu não iria ter um bom momento naquela hora.!"
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                            new Fala (
                                                "Amigo de infância",
                                                Status.Sucesso,
                                                new List<string> {
                                                    "Então ele começou a andar na minha direção...",
                                                    "e tivemos uma luta estilo JOJO e eu ganhei!"
                                                },
                                                Proximo.NDA,
                                                new List<int>{},
                                                new List<string> {},
                                                new List<Fala>{}
                                            ),
                                        }
                                    )
                                }
                            )
                        }
                    )
                }
            )
        }
    );
}

public class Fala
{
    public string id;
    public Status status;
    public List<string> falas;
    public Proximo proximo;
    public List<int> listadeProbabilidades;
    public List<string> listaDeOpcoes;
    public List<Fala> listaDeRamos;
    public Fala(string id1, Status status1, List<string> falas1, Proximo proximo1, List<int> listadeProbabilidades1, List<string> listaDeOpcoes1,List<Fala> listaDeRamos1)
    {
        id = id1;
        status = status1;
        falas = falas1;
        listaDeOpcoes = listaDeOpcoes1;
        listaDeRamos = listaDeRamos1;
        proximo = proximo1;
    }
    public Fala () {}
}

public enum Status
{
    Nulo,
    Sucesso,
    Falha
}

public enum Proximo
{
    Probabilistico,
    Escolha,
    NDA
}