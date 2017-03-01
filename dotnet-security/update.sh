for f in *.puml
do 
    java -jar $(cygpath -w ~/professional/software/devtools/plantnuml/plantuml.jar) $f
done
