package uk.ac.gla.terrier.structures.trees;

import java.util.HashSet;
import java.util.Stack;

/**
 * This class implements the binary tree containing the terms found in a document
 * 
 * @author Gerald van Veldhuijsen
 * @version 1.0
 */
public class DICOMFieldDocumentTree extends FieldDocumentTree {
	/** The root of the binary tree.*/
	protected DICOMFieldDocumentTreeNode treeRoot = null;
	/** The number of nodes in the tree.*/
	protected int numberOfNodes;
	/** The number of pointers in the tree.*/
	protected int numberOfPointers;
	/** A counter for using in the traversePreOrder method.*/
	protected int counter;
	
	/** A FieldDocumentTreeNode buffer used in the traversePreOrder method.*/
	private DICOMFieldDocumentTreeNode[] nodeBuffer;
	/** 
	 * Empties the tree.
	 */
	public void empty() {
		treeRoot = null;
		numberOfPointers = 0;
		numberOfNodes = 0;
	}
	/**
	* Returns the number of nodes in the tree.
	* @return int the number of nodes in the tree.
	*/
	public int getNumberOfNodes() {
		return numberOfNodes;
	}
	/**
	 * Returns the number of pointers in the tree.
	 * @return int the number of pointers in the tree.
	 */
	public int getNumberOfPointers() {
		return numberOfPointers;
	}
	/**
	 * Inserts a new term in the field document binary tree.
	 * @param newTerm The term to be inserted.
	 */
	public void insert(String newTerm) {
		if (treeRoot==null) {
			treeRoot = new DICOMFieldDocumentTreeNode(newTerm);
			numberOfNodes++;
			numberOfPointers++;			
		} else {
			DICOMFieldDocumentTreeNode tmpNode = treeRoot;		
			while (true) {
				int lexicographicOrder = tmpNode.getTerm().compareTo(newTerm);
				//int lexicographicOrder = Compare.compareWithNumeric(tmpNode.term, newTerm);
				if (lexicographicOrder == 0) {
					tmpNode.frequency++;
					numberOfPointers++;
					break;
				} else if (lexicographicOrder > 0) {
					if (tmpNode.left==null) {
						tmpNode.left = new DICOMFieldDocumentTreeNode(newTerm);
						numberOfNodes++;
						numberOfPointers++;
						break;
					} else 
						tmpNode = tmpNode.left; 
				} else {
					if (tmpNode.right==null) {
						tmpNode.right = new DICOMFieldDocumentTreeNode(newTerm);
						numberOfNodes++;
						numberOfPointers++;						
						break;
					} else 
						tmpNode = tmpNode.right;
				}
			}
		}
	}
	
	/**
	 * Inserts a new term in the field document binary tree.
	 * @param newTerm String the term to be inserted.
	 * @param field String the field in which the term appears.
	 */
	public void insert(String newTerm, String field) {
		if (treeRoot==null) {
			treeRoot = new DICOMFieldDocumentTreeNode(newTerm, field);
			numberOfNodes++;
			numberOfPointers++;			
		} else {
			DICOMFieldDocumentTreeNode tmpNode = treeRoot;
			while (true) {
				int lexicographicOrder = tmpNode.getTerm().compareTo(newTerm);
				//int lexicographicOrder = Compare.compareWithNumeric(tmpNode.term, newTerm);
				if (lexicographicOrder == 0) {
					tmpNode.frequency++;
					tmpNode.addToFieldScore(field);
					numberOfPointers++;
					break;
				} else if (lexicographicOrder > 0) {
					if (tmpNode.left==null) {
						tmpNode.left = new DICOMFieldDocumentTreeNode(newTerm,field);
						numberOfNodes++;
						numberOfPointers++;
						break;
					} else 
						tmpNode = tmpNode.left; 
				} else {
					if (tmpNode.right==null) {
						tmpNode.right = new DICOMFieldDocumentTreeNode(newTerm,field);
						numberOfNodes++;
						numberOfPointers++;						
						break;
					} else 
						tmpNode = tmpNode.right;
				}
			}
		}
	}
	/**
	 * Inserts a new term in the html document binary tree.
	 * @param newTerm String the term to be inserted.
	 * @param fields HashSet the fields in which the term appears.
	 */
	public void insert(String newTerm, HashSet fields) {
		if (treeRoot==null) {
			treeRoot = new DICOMFieldDocumentTreeNode(newTerm, fields);
			numberOfNodes++;
			numberOfPointers++;			
		} else {
			DICOMFieldDocumentTreeNode tmpNode = treeRoot;
			while (true) {
				int lexicographicOrder = tmpNode.getTerm().compareTo(newTerm);
				//int lexicographicOrder = Compare.compareWithNumeric(tmpNode.term, newTerm);
				if (lexicographicOrder == 0) {
					tmpNode.frequency++;
					tmpNode.addToFieldScore(fields);
					numberOfPointers++;
					break;
				} else if (lexicographicOrder > 0) {
					if (tmpNode.left==null) {
						tmpNode.left = new DICOMFieldDocumentTreeNode(newTerm, fields);
						numberOfNodes++;
						numberOfPointers++;
						break;
					} else 
						tmpNode = tmpNode.left; 
				} else {
					if (tmpNode.right==null) {
						tmpNode.right = new DICOMFieldDocumentTreeNode(newTerm, fields);
						numberOfNodes++;
						numberOfPointers++;						
						break;
					} else 
						tmpNode = tmpNode.right;
				}
			}
		}
	}
	
	/**
	 * Inserts a new term in the html document binary tree.
	 * @param newTerm String the term to be inserted.
	 * @param fields Stack the ordered fields in which the term appears.
	 */
	public void insert(String newTerm, Stack fields) {
		if (treeRoot==null) {
			treeRoot = new DICOMFieldDocumentTreeNode(newTerm, fields);
			numberOfNodes++;
			numberOfPointers++;			
		} else {
			DICOMFieldDocumentTreeNode tmpNode = treeRoot;
			while (true) {
				int lexicographicOrder = tmpNode.getTerm().compareTo(newTerm);
				//int lexicographicOrder = Compare.compareWithNumeric(tmpNode.term, newTerm);
				if (lexicographicOrder == 0) {
					tmpNode.frequency++;
					tmpNode.addToFieldScore(fields);
					numberOfPointers++;
					break;
				} else if (lexicographicOrder > 0) {
					if (tmpNode.left==null) {
						tmpNode.left = new DICOMFieldDocumentTreeNode(newTerm, fields);
						numberOfNodes++;
						numberOfPointers++;
						break;
					} else 
						tmpNode = tmpNode.left; 
				} else {
					if (tmpNode.right==null) {
						tmpNode.right = new DICOMFieldDocumentTreeNode(newTerm, fields);
						numberOfNodes++;
						numberOfPointers++;						
						break;
					} else 
						tmpNode = tmpNode.right;
				}
			}
		}
	}
	
	
	/**
	 * Returns an array of the term nodes of the tree.
	 */
	public FieldDocumentTreeNode[] toArray() {
		nodeBuffer = new DICOMFieldDocumentTreeNode[numberOfNodes];
		counter = 0;
		traversePreOrder(treeRoot);
		return nodeBuffer;
	}
	/** 
	 * The helper for returning the buffer of terms of the document.
	 * @param node FieldDocumentTreeNode The node to insert to the buffer
	 */
	protected void traversePreOrder(DICOMFieldDocumentTreeNode node) {
		if (node == null)
			return;
		nodeBuffer[counter] = node;
		counter++;
		traversePreOrder(node.left);
		traversePreOrder(node.right);
	}
}
