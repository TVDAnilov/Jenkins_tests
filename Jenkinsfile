pipeline {
    agent none
    
    stages {
        stage('Приветствие') {
            agent any
            steps {
                echo "Привет, мир!"
            }
        }
        
        stage('Подготовка') {
            parallel {
                stage('Сборка на node1') {
                    agent { label 'node1' }
                    steps {
                        echo "Выполняется сборка на node1..."
                    }
                }
                stage('Сборка на node2') {
                    agent { label 'node2' }
                    steps {
                        echo "Выполняется сборка на node2..."
                    }
                }
            }
        }
        
        stage('Тесты') {
            parallel {
                stage('Тесты на node1') {
                    agent { label 'node1' }
                    steps {
                        echo "Выполняются тесты на node1..."
                    }
                }
                stage('Тесты на node2') {
                    agent { label 'node2' }
                    steps {
                        echo "Выполняются тесты на node2..."
                        // Добавьте команды для запуска тестов на node2
                    }
                }
            }
        }
        
        stage('Сообщение после сборки') {
            agent any
            steps {
                echo "Сборка и тесты завершены!"
                // Добавьте команды для отправки сообщения после сборки и тестов
            }
        }
    }
}
