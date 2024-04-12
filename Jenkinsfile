pipeline {
    agent none // Не выбираем агента здесь, так как будем использовать несколько агентов параллельно

    stages {
        stage('Build and Test') {
            agent { node { label 'node1' } } // Выбираем агент node1 для сборки и тестирования
            steps {
                //git 'https://github.com/TVDAnilov/Jenkins_tests.git'
            }
        }

        stage('Parallel Actions') {
            parallel { // Параллельный блок
                stage('Node1') {
                    agent { node { label 'node1' } } // Выбираем агент node1 для этой части
                    steps {
                        echo 'Выполняется на node1'
                     }
                }
                stage('Node2') {
                    agent { node { label 'node2' } } // Выбираем агент node2 для этой части
                    steps {
                        echo 'Выполняется на node2'
                    }
                }
            }
        }
    }
}